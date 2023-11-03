using Managers;
using TMPro;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [Header("List Objects")]
    [SerializeField] private GridVerticalList AdCompanyList;
    [SerializeField] private GridVerticalList CompanyRankingList;
    [Header("Text Objects")]
    [SerializeField] private TextMeshProUGUI time;
    [SerializeField] private TextMeshProUGUI money;
    [SerializeField] private TextMeshProUGUI totalDay;
    [SerializeField] private TextMeshProUGUI day;
    [SerializeField] private TextMeshProUGUI currentPower;
}
