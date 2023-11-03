using Data;
using Managers;
using UnityEngine;

public class StaticDataManager : Singleton<StaticDataManager>
{
    [SerializeField] public AdCompanyDatabase adCompanyDatabase;
    [SerializeField] public WtCompanyDatabase wtCompanyDatabase;
}
