using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int balance;
    public int Lifes = 3;
    [SerializeField] TextMeshProUGUI _balanceText;
    [SerializeField] List<GameObject> _lifesImages;

    void Start()
    {
        Debug.Log(balance);
        balance = Progress.Instance.balance;
        Debug.Log(balance);
        ChangeBalance(0);
    }

    public void ChangeBalance(int value)
    {
        balance += value;
        _balanceText.text = balance.ToString(); 
    }

    public void MinusLife()
    {
        Lifes--;

        if (Lifes >= 0)
            _lifesImages[Lifes].SetActive(false);

        if (Lifes == 0)
        {
            Progress.Instance.balance = balance;
            FindAnyObjectByType<ButtonManager>().EndGame();
        }
       
    }



}
