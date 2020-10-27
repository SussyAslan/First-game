using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AslanSpace
{
   
    public class Enemy : ScriptableObject 
    {
        [SerializeField]
        private int _Id;
        [SerializeField]
        private int _Health;
        [SerializeField]
        private int _Armor;
        [SerializeField]
        private int _LevelXP;
     
        [SerializeField]
        private string _Name;
        [SerializeField]
        private string _Profession;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int Health
        {
            get { return _Health; }
            set { _Health = value; }
        }
        public int Armor
        {
            get { return _Armor; }
            set { _Armor = value; }
        }
        public int LevelXP
        {
            get { return _LevelXP; }
            set { _LevelXP = value; }
        }
 
        public string Name
        {
            get { return _Name;  }
            set { _Name = value; }
        }

        public string Profession
        {
            get { return _Profession; }
            set { _Profession = value; }
        }

    }

}
