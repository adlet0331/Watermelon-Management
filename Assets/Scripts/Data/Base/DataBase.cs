using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace DataBaseScripts.Base
{
    public abstract class DataBase<T> : ScriptableObject where T : DataType
    {
        [SerializeField] protected string databaseName;
        public List<T> dataList;
        [SerializeField] private bool needToBeWritable;

        private void Awake()
        {
            LoadJson();
        }

        public void LoadJson()
        {
            string json;
            string path;
            if (needToBeWritable) // 프로젝트 바깥, 기기에 저장될 아이들
            {
                path = Path.Combine(Application.persistentDataPath, databaseName+".json");
                using (StreamReader file = File.OpenText(path))
                {
                    json = file.ReadToEnd();
                    dataList = JsonConvert.DeserializeObject<List<T>>(json);
                }
            }
            else // 프로젝트 안, 변하지 않을 데이터, StaticData
            {
                path = Path.Combine("IngameData", "Json", databaseName);
                json = Resources.Load<TextAsset>(path).ToString();
                dataList = JsonConvert.DeserializeObject<List<T>>(json);
            }
        }
        public void SaveJson(){
            string path = Path.Combine(Application.dataPath, "Resources", "IngameData", "Json", databaseName + ".json");
            File.WriteAllText(path, JsonConvert.SerializeObject(dataList, Formatting.Indented));
        }
    }
}
