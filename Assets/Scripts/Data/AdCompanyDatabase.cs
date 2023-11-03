using System;
using Data;
using DataBaseScripts.Base;
using UnityEditor;
using UnityEngine;

namespace Data
{
    [Serializable]
    public class AdCompanyData : DataType
    {
        public int StartCost;
        public int StartPower;
        public int costChangePerDay;
        public int powerChangePerDay;
        public float costGradientVar;
        public float powerGradientVar;
        public float randomVar;
    }

    [CreateAssetMenu(fileName = "AdCompanyDatabase", menuName = "ScriptableObjects/AdCompanyDatabase", order = 1)]
    public class AdCompanyDatabase : DataBase<AdCompanyData>
    {
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(AdCompanyDatabase))]
    public class AdCompanyDatabaseEditor : DataBaseEditor<AdCompanyDatabase, AdCompanyData>
    {
    }
#endif
}