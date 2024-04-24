using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float Money;

    [SerializeField] TextMeshProUGUI _MoneyCount;

    private void Start()
    {
        CrashProgress.Instance.progressMoney = Progress.Instance.balance;
        Money = CrashProgress.Instance.progressMoney;

        ShowMoney();
    }

    public void MinusMoney(float fl)
    {
        Money = Money - fl;
    }

    public void ShowMoney()
    {
        Money = Mathf.Round(Money * 100f) / 100f;
        _MoneyCount.text = Money.ToString() + "$";
    }

}
