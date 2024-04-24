using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    double currentime = 5;

    [SerializeField] CrashGameManager gameManager;

    [SerializeField] TextMeshProUGUI _text;


    void Update()
    {
        currentime -= Time.deltaTime;

        if(currentime <= 0 && gameManager.enabled == false)
        {
            gameManager.StartGame();

            _text.text = "start";
        }
        else if(gameManager.enabled == true)
        {
            _text.text = "";
        }
        else
        {
            float Money = Convert.ToSingle(currentime);
            Money = Mathf.Round(Money * 100f) / 100f;
            _text.text = Money.ToString() + "sec";
        }
        
    }
}
