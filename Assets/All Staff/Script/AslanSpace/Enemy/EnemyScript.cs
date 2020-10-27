using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AslanSpace
{

    public class EnemyScript : MonoBehaviour
    {
        [Header("Enemy Stats")]
        public string Name;
        public string Profession;

        public int XP;
        public int Health;
        public int Armor;
        public int MPA;
        public int Dmg;

        int lv = 0;      
        public GameObject GaneralGameScript;
        SpawnUnitsScript spawnUnitsScript;
        BattleSystem battleSystem;

        public List<skill> skills = new List<skill>();
        public List<Warrior> warrior = new List<Warrior>();
        public List<Mage> mage = new List<Mage>();
        public List<Ranger> ranger = new List<Ranger>();      
        void Start()

        {            
            GetStats();         
            GaneralGameScript = GameObject.Find("GaneralGameScript");
            spawnUnitsScript = GaneralGameScript.GetComponent<SpawnUnitsScript>();
            battleSystem = GaneralGameScript.GetComponent<BattleSystem>();


        }

        void Update()
        {

        }
        public bool TakeDmg(int Dmg)
        {
            Health -= Dmg;
            if (Health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        void GetStats()
        {
            if (warrior.Count != 0)
            {
                Name = warrior[lv].Name;
                Profession = warrior[lv].Profession;
                XP = warrior[lv].LevelXP;
                Health = warrior[lv].Health;
                Armor = warrior[lv].Armor;
                MPA = warrior[lv].MeleePhysicalAtack;
                Dmg = warrior[lv].MeleePhysicalAtack;
            }
            else if (mage.Count != 0)
            {
                Name = mage[lv].Name;
                Profession = mage[lv].Profession;
                XP = mage[lv].LevelXP;
                Health = mage[lv].Health;
                Armor = mage[lv].Armor;
                MPA = mage[lv].RangeMagicAttack;
                Dmg = mage[lv].RangeMagicAttack;
            }
            else if (ranger.Count != 0)
            {
                Name = ranger[lv].Name;
                Profession = ranger[lv].Profession;
                XP = ranger[lv].LevelXP;
                Health = ranger[lv].Health;
                Armor = ranger[lv].Armor;
                MPA = ranger[lv].RangePhysicalAttack;
                Dmg = ranger[lv].RangePhysicalAttack;

            }
        }
    }
}
