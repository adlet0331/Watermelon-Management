using UnityEngine;

public class AdCompanyObject : MonoBehaviour
{
    [SerializeField] private int companyId;
    [SerializeField] private ValChangeObject money;
    [SerializeField] private ValChangeObject power;

    public void Init(int id, int moneyChange, int powerChange)
    {
        companyId = id;
        UpdateValues(moneyChange, powerChange);
    }
    public void UpdateValues(int moneyChange, int powerChange)
    {
        money.UpdateValue(moneyChange);
        power.UpdateValue(powerChange);
    }
    public void Shoot()
    {
        
    }
}
