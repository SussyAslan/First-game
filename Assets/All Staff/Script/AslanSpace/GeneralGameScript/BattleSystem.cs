using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AslanSpace
{
    public enum BattleState { START, PLAYERTURN, ENEMYTURN, LOST,WON }

    public class BattleSystem : MonoBehaviour
    {
        public BattleState state;
        public SpawnUnitsScript spawnUnitsScript;
        
        public void PreSetupBattle()
        {
            state = BattleState.START;          
            StartCoroutine(SetupBattle());
        }
         IEnumerator SetupBattle()
        {
            Debug.Log("Walka sie rozpoczeła");
            yield return new WaitForSeconds(1f);
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }


        IEnumerator PlayerAttack()
        {
            int DmgToEnemy = spawnUnitsScript.playerTest.DmgCalculation(spawnUnitsScript.playerTest.PlayerSkills);
            bool isDeadEnemy = spawnUnitsScript.playerTest.enemyScript.TakeDmg(DmgToEnemy);          
            Debug.Log("Przeciwnik Dostał" + DmgToEnemy + "Dmg"); 
            

            yield return new WaitForSeconds(1f);

            if (isDeadEnemy)
            {
                state = BattleState.WON;
                EndBattle();

            }else
            {
                state = BattleState.ENEMYTURN;
                StartCoroutine(EnemyTurn());
            }

        }
        IEnumerator EnemyTurn()
        {        
            yield return new WaitForSeconds(0.5f);

            int DmgToPlayer = spawnUnitsScript.playerTest.enemyScript.Dmg;       
            bool isDeadPlayer = spawnUnitsScript.playerTest.TakeDmg(DmgToPlayer);
            Debug.Log("Dostałeś" + DmgToPlayer + "Dmg od przeciwnika");
            yield return new WaitForSeconds(0.5f);
            if (isDeadPlayer)
            {
                state = BattleState.LOST;
                yield return new WaitForSeconds(0.5f);
                EndBattle();
            }else
            {
            state = BattleState.PLAYERTURN;
                yield return new WaitForSeconds(0.5f);
                PlayerTurn();

            }

           

        }
        void EndBattle()
        {
            if(state == BattleState.WON)
            {
                Debug.Log(spawnUnitsScript.playerTest.CurrentEnemy.name + "Pokonany");
                Destroy(spawnUnitsScript.playerTest.CurrentEnemy);
                spawnUnitsScript.EnemyCountsubtraction(1);
            }else if(state == BattleState.LOST){
                Debug.Log("Zostałeś pokonany.");
            }
          
        }
        void PlayerTurn()
        {
            Debug.Log("Zaatakuj przeciwnka");
        }

        public void AttackButton()
        {
            if(state != BattleState.PLAYERTURN)
            {
                return;
            }            
           StartCoroutine(PlayerAttack());

        }

    }
}
