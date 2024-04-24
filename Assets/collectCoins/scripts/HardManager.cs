using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardManager : MonoBehaviour
{
    [SerializeField] float _timeBefHarder;
    float timer;

    void Start()
    {
        timer = _timeBefHarder;
    }
    void LateUpdate()
    {
        if (FindAnyObjectByType<ButtonManager>().StartGame)
        {
            if (timer < 0)
            {
                if (FindAnyObjectByType<SpawnManager>().TimeBefSpawn > 0.1f)
                    FindAnyObjectByType<SpawnManager>().TimeBefSpawn -= 0.1f;
                FindAnyObjectByType<CoinManager>().CoinSpeed += 1;
                timer = _timeBefHarder;
            }
            else
                timer -= Time.deltaTime;
        }
    }
}
