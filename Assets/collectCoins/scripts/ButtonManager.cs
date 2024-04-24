using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public bool StartGame = false;
    [SerializeField] GameObject _userInterface;
    [SerializeField] GameObject _casinoSelect;


    public void StartButton()
    {
        _userInterface.SetActive(false);
        StartGame = true;
    }

    public void ShopButton()
    {
        _userInterface.SetActive(false);
        _casinoSelect.SetActive(true);
    }
    public void ExitCasinoButton()
    {
        _userInterface.SetActive(true);
        _casinoSelect.SetActive(false);
    }

    public void SlotsSelect()
    {
        SceneManager.LoadScene("slotsPref");
    }


    public void CrushSelect()
    {
        SceneManager.LoadScene("crashScene");
    }

    public void RoulleteSelect()
    {
        SceneManager.LoadScene("Roulette");
    }

    public void EndGame()
    {
        StartGame = false;
        FindAnyObjectByType<SpawnManager>().TimeBefSpawn = 1f;
        FindAnyObjectByType<CoinManager>().CoinSpeed = 10;
        FindAnyObjectByType<GameManager>().Lifes = 3;
        _userInterface.SetActive(true);
    }



}
