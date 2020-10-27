using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AslanSpace
{
    public class PlayerTest : MonoBehaviour
    {
        [Header("PlayerStats")]
        public int Health = 100;
        public int Attack = 5;
        public float PlayerMovementSpeed = 5f;
        public List<skill> PlayerSkills = new List<skill>();
     
        public bool IsInEnemy = false;

        public Rigidbody2D rb;
        public Vector2 Movement;

        public GameObject CurrentEnemy;
        public EnemyScript enemyScript;
        public GameObject GaneralGameScript;
        SpawnUnitsScript spawnUnitsScript;
        BattleSystem battleSystem;

        void Start()
        {
            GaneralGameScript = GameObject.Find("GaneralGameScript");
            spawnUnitsScript = GaneralGameScript.GetComponent<SpawnUnitsScript>();
            battleSystem = GaneralGameScript.GetComponent<BattleSystem>();
        }

        void Update()
        {

            Movement.x = Input.GetAxisRaw("Horizontal"); // Player Movement A/D AND Left Arrow/ Right Arrow
            Movement.y = Input.GetAxisRaw("Vertical");   // Player Movement W/D AND Up Arrow / Down Arrow         
            if (Input.GetKeyDown(KeyCode.Alpha1) && IsInEnemy ) // If Player Press no.1
            {                            
                battleSystem.AttackButton();              
            }
        }
        void FixedUpdate()
        {
            if (!IsInEnemy) // Player Movement 
            {
                rb.MovePosition(rb.position + Movement * PlayerMovementSpeed * Time.fixedDeltaTime);
            }
        }
        private void OnTriggerEnter2D(Collider2D collision) // Collision with enemy Enter
        {
            IsInEnemy = true;
            CurrentEnemy = GameObject.Find(collision.name);
            enemyScript = CurrentEnemy.GetComponent<EnemyScript>();
            battleSystem.PreSetupBattle();
            
          
        }
        private void OnTriggerExit2D(Collider2D collision) // Collision with enemy Exit
        {

            IsInEnemy = false;
        }
        public bool TakeDmg(int Dmg)
        {
            Health -= Dmg;
            if (Health <= 0)
            {
                return true;
            }else
            {
                return false;
            }

        }
        public int DmgCalculation(List<skill> skills)
        {
            int Dmgmin = skills[0].DmgMin;
            int Dmgmax = skills[0].DmgMax;

            int Dmg = Random.Range(Dmgmin, Dmgmax) + Attack;    
            return Dmg;
        }
    }
}
