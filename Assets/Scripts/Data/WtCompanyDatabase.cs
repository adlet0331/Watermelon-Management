using System;
using DataBaseScripts.Base;
using UnityEditor;
using UnityEngine;

namespace Data
{
    [Serializable]
    public class WtCompanyData : DataType
    {
        public int power;
        public int powerChangePerDay;
        public float powerGradientVar;
        public float randomVar;
    }
    [CreateAssetMenu(fileName = "WtCompanyDatabase", menuName = "ScriptableObjects/WtCompanyDatabase", order = 1)]
    public class WtCompanyDatabase : DataBase<WtCompanyData> { }
#if UNITY_EDITOR
    [CustomEditor(typeof(WtCompanyDatabase))]
    public class WtCompanyDatabaseEditor : DataBaseEditor<WtCompanyDatabase, WtCompanyData> { }
#endif
}