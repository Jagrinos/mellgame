using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows;

public class CrashGameManager : MonoBehaviour
{
    private CrashGameManager gameManager;

    private bool explosion = false;

    [SerializeField] ParticleSystem _explosion;

    [SerializeField] GameObject _explosionSound;

    [SerializeField] BezierTest _progress;
    [SerializeField] GameObject _mainCube;
    [SerializeField] GameObject _background;

    [SerializeField] MoneyManager _moneyManager;

    [SerializeField] FactorManager _factorManager;

    [SerializeField] TMP_InputField _inputField;

    [SerializeField] Button _button;

    private float liveTime;
    private double currentTime;

    private void Awake()
    {
        gameManager = GetComponent<CrashGameManager>();


        gameManager.enabled = false;
        _progress.enabled = false;
        _factorManager.enabled = false;
    }

    private void Start()
    {
        try
        {
            float textnumber = float.Parse(_inputField.text);

            if (textnumber <= _moneyManager.Money)
            {
                _moneyManager.MinusMoney(textnumber);
                _moneyManager.ShowMoney();
            }
            else
            {
                _inputField.text = "You don't have enough money";
            }
        }
        catch
        {
            
        }
    }


    public void StartGame()
    {
        liveTime = UnityEngine.Random.Range(0.1f, 20f);

        gameManager.enabled = true;
        _progress.enabled = true;
        _factorManager.enabled = true;

        _inputField.gameObject.SetActive(false);
    }

    public void TakeMoney()
    {
        float _scale = _factorManager._scale;
        try
        {
            _moneyManager.Money += _scale * float.Parse(_inputField.text);

            _moneyManager.ShowMoney();

            Progress.Instance.balance = (int) _moneyManager.Money;

            _button.gameObject.SetActive(false);
        }
        catch
        {

        }
    }

    void Update()
    {
        

        currentTime += Time.deltaTime;

        if(_mainCube.transform.position.x > 7.30)
        {
            _background.transform.position -= new Vector3(0, 0.001f, 0);
        }

        if (currentTime >= liveTime)
        {
            _explosionSound.SetActive(true);

            _mainCube.SetActive(false);

            if (explosion == false)
            {
                Instantiate(_explosion, _mainCube.transform.position, _mainCube.transform.rotation);
                explosion = true; 
            }

            _progress.enabled = false;    

            _factorManager.enabled = false;

            _button.gameObject.SetActive(false);

            CrashProgress.Instance.progressMoney = _moneyManager.Money;

            StartCoroutine(reload());
        }
     
    }  

    IEnumerator reload()
    {
        yield return new WaitForSeconds(3f);
        Progress.Instance.balance = (int) CrashProgress.Instance.progressMoney;
        SceneManager.LoadScene("crashScene"); 
    }

    public void exit()
    {
        //Progress.Instance.balance = (int)CrashProgress.Instance.progressMoney;
        
        SceneManager.LoadScene("CollectCoins");
    }
}
