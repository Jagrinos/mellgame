using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrCoin4 : MonoBehaviour
{
    [SerializeField] int _coinValue = 50;
    CoinManager CoinManager;
    GameManager GameManager;

    void Start()
    {
        CoinManager = FindAnyObjectByType<CoinManager>();
        GameManager = FindAnyObjectByType<GameManager>();
    }

    private void Update()
    {
        CoinManager.CoinMove(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMove>())
        {
            FindAnyObjectByType<AudioManager>().PlayAmAm();
            GameManager.ChangeBalance(_coinValue);
            Destroy(gameObject);
        }

        if (collision.gameObject.GetComponent<Ground>())
        {
            FindAnyObjectByType<AudioManager>().PlayMinusHp();
            GameManager.MinusLife();
            Destroy(gameObject);
        }
    }
}
