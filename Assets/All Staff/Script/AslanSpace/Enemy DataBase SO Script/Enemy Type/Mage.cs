using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AslanSpace
{
    [CreateAssetMenu(fileName = "Mage", menuName = "Enemy/Mage")]
    public class Mage : Enemy
    {
        [SerializeField]
        private int _RangeMagicAttack;

        public int RangeMagicAttack
        {
            get { return  _RangeMagicAttack; }
            set { _RangeMagicAttack = value; }
        }
        public Mage()
        {
            Id = 0;
            Health = 15;
            Armor = 2;
            RangeMagicAttack = 9;
            LevelXP = 1;

            Name = "default";
            Profession = "Mage";
        }
    }
}
