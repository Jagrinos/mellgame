using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class balance : MonoBehaviour
{
    public int Balance = 0;
    [SerializeField] TextMeshProUGUI _balanceText;
    public int Bet = -1;

    void Start()
    {
        Balance = Progress.Instance.balance;
        UpdateBalance(0);
    }

    public void UpdateBalance(int value)
    {
        Balance += value;
        _balanceText.text = Balance.ToString();
    }

    public void ChangeBet(string bet) 
    {
        bool isInt = int.TryParse(bet, out Bet);
        if (isInt)
        {
            if (Bet < 0) Bet *= -1;
            if (Bet > Balance) Bet = -1;
        }
        else
        {
            Bet = -1;
        }
        Debug.Log(Bet);
    }


}
