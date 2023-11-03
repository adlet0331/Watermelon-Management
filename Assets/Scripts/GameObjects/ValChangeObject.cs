using System;
using TMPro;
using UnityEngine;

public class ValChangeObject : MonoBehaviour
{
    [SerializeField] private String suffix;
    [SerializeField] private TextMeshProUGUI currentValue;
    [SerializeField] private TextMeshProUGUI changedValue;
    
    public void UpdateValue(int addValue)
    {
        currentValue.text = Int32.Parse(currentValue.text + addValue).ToString();
        currentValue.text += suffix;
        if (addValue > 0)
        {
            changedValue.text = "+";
            changedValue.text += addValue.ToString();
            changedValue.color = Color.red;
        }
        else if (addValue < 0)
        {
            changedValue.text = "-";
            changedValue.text += addValue.ToString();
            changedValue.color = Color.blue;
        }
        else
        {
            changedValue.text = "-";
            changedValue.color = Color.black;
        }
    }
}
