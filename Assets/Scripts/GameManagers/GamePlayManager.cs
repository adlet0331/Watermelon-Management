using System.Collections.Generic;
using System.Linq;
using Data;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayManager : Managers.Singleton<GamePlayManager>
{
    [Header("Companies")] 
    [SerializeField] private int AdCompanyInitNum;
    [SerializeField] private List<AdCompanyData> AdCompanyDatas;
    [SerializeField] private int WtCompanyInitNum;
    [SerializeField] private List<WtCompanyData> WtCompanyDatas;
    public void Start()
    {
        for (int i = 0; i < WtCompanyInitNum; i++)
        {
            CreateNewWtCompany();
        }
        for (int i = 0; i < AdCompanyInitNum; i++)
        {
            CreateNewAdCompany();
        }
        RotateClock(90);
    }

    private bool CreateNewWtCompany()
    {
        if (StaticDataManager.Instance.wtCompanyDatabase.dataList.Count == WtCompanyDatas.Count)
        {
            return false;
        }
        while (true)
        {
            int index = Random.Range(0, StaticDataManager.Instance.wtCompanyDatabase.dataList.Count);
            if (WtCompanyDatas.FindIndex(x => x.idx == index) != -1)
            {
                var item = StaticDataManager.Instance.wtCompanyDatabase.dataList[index];
                item.randomVar = Random.value;
                WtCompanyDatas.Add(item);
                return true;
            }
        }
    }
    private bool CreateNewAdCompany()
    {
        if (StaticDataManager.Instance.adCompanyDatabase.dataList.Count == AdCompanyDatas.Count)
        {
            return false;
        }
        while (true)
        {
            int index = Random.Range(0, StaticDataManager.Instance.adCompanyDatabase.dataList.Count);
            if (AdCompanyDatas.FindIndex(x => x.idx == index) != -1)
            {
                var item = StaticDataManager.Instance.adCompanyDatabase.dataList[index];
                item.randomVar = Random.value;
                AdCompanyDatas.Add(item);
                return true;
            }
        }
    }

    [Header("Time Flowing")] 
    [SerializeField] private Image WatermelonClock;
    private void RotateClock(float degree)
    {
        WatermelonClock.fillAmount = 1f - 1f / (float)degree;
        WatermelonClock.transform.Rotate(0, 0, 1f / (float)degree * 360f);
    }

    public void StartSingleDay()
    {
        
    }
}
