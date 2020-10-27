using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AslanSpace
{
    [CreateAssetMenu(fileName = "Skill", menuName = "Skills/Skills")]
    public class skill : ScriptableObject
    {
        [SerializeField]
        private string _Name;
        [SerializeField]
        private string _Destription;
        [SerializeField]
        private int _Dmg;
        [SerializeField]
        private int _DmgMin;
        [SerializeField]
        private int _DmgMax;
        [SerializeField]
        private int _Cooldown;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Destription
        {
            get { return _Destription; }
            set { _Destription = value; }
        }
        public int Dmg
        {
            get { return _Dmg; }
            set { _Dmg = value; }
        }
        public int DmgMin
        {
            get { return _DmgMin; }
            set { _DmgMin = value; }
        }
        public int DmgMax
        {
            get { return _DmgMax; }
            set { _DmgMax = value; }
        }
        public int Cooldown
        {
            get { return _Cooldown; }
            set { _Cooldown = value; }
        }
    }
}
