
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AslanSpace
{
    public class SpawnUnitsScript : MonoBehaviour
    {

        public GameObject playerPrefab;
        public GameObject enemyWarriorPrefab;
        public GameObject enemyRangerPrefab;
        public GameObject enemyMagePrefab;

        public BattleSystem battleSystem;

        GameObject enemy;

        public PlayerTest playerTest;
        public EnemyScript enemyScript;

        public float xPos;
        public float yPos;
        public int enemyCount;

        int mageCount = 0;
        int warriorCount = 0;
        int rengerCount = 0;

        public int Floor;
        public int Room;

        void Start()
        {
            EnemyAndPLayerDrop();
        }

        void EnemyAndPLayerDrop()
        {
            GameObject player = Instantiate(playerPrefab);
            playerTest = player.GetComponent<PlayerTest>();
            StartCoroutine(EnemyDrop());
        }

        IEnumerator EnemyDrop()
        {
            while (enemyCount < 20)
            {
                int randomEnemy = Random.Range(1, 4);
                switch (randomEnemy)
                {
                    case 1:
                        xPos = Random.Range(-7.30f, 6.30f);
                        yPos = Random.Range(-4.77f, 4.34f);
                        enemy = Instantiate(enemyWarriorPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
                        warriorCount++;
                        enemy.name = "Warrior" + warriorCount;
                        enemyCount++;
                        break;
                    case 2:
                        xPos = Random.Range(-7.30f, 6.30f);
                        yPos = Random.Range(-4.77f, 4.34f);
                        enemy = Instantiate(enemyMagePrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
                        mageCount++;
                        enemy.name = "Mage" + mageCount;
                        enemyCount++;
                        break;
                    case 3:
                        xPos = Random.Range(-7.30f, 6.30f);
                        yPos = Random.Range(-4.77f, 4.34f);
                        enemy = Instantiate(enemyRangerPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
                        rengerCount++;
                        enemy.name = "Ranger" + rengerCount;
                        enemyCount++;
                        break;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }

        public void EnemyCountsubtraction (int subtraction)
        {
            enemyCount -= subtraction;
        }

    }
}
