using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AslanSpace
{
    [CreateAssetMenu(fileName = "Warior", menuName = "Enemy/Warior")]
    public class Warrior : Enemy
    {
  
        [SerializeField]
        private int _MeleePhysicalAttack;

        public int MeleePhysicalAtack
        {
            get { return _MeleePhysicalAttack; }
            set { _MeleePhysicalAttack = value; }
        }      
        public Warrior()
        {
            Name = "default";
            Profession = "Warrior";

            LevelXP = 1;
            Id = 0;          
            Health = 30;
            Armor = 4;
            MeleePhysicalAtack = 5;
            
        }
       
    }
}