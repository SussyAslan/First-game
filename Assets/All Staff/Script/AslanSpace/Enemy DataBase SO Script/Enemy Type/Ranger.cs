using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AslanSpace
{
    [CreateAssetMenu(fileName = "Ranger", menuName = "Enemy/Ranger")]
    public class Ranger : Enemy
    {
        [SerializeField]
        private int _RangePhysicalAttack;

        public int RangePhysicalAttack
        {
            get { return _RangePhysicalAttack; }
            set { _RangePhysicalAttack = value; }
        }
        public Ranger()
        {
            Id = 0;
            Health = 25;
            Armor = 3;
            RangePhysicalAttack = 7;
            LevelXP = 1;

            Name = "default";
            Profession = "Ranger";
        }
    }
}
