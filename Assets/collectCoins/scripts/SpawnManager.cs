using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> coins = new();
    public float TimeBefSpawn;

    ButtonManager ButtonManager;
    float timer;

    void Start()
    {
        ButtonManager = FindAnyObjectByType<ButtonManager>();
        timer = TimeBefSpawn;
    }

    void Update()
    {
        if (ButtonManager.StartGame)
        {
            if (timer <= 0)
            {
                timer = TimeBefSpawn;
                spawn();
            }
            else
                timer -= Time.deltaTime;
        }
    }

    void spawn()
    {
        Instantiate(
            coins[Random.Range(0, coins.Count)],
            new Vector3(Random.Range(-8f,8f), 4.5f, -1f),
            gameObject.transform.rotation
            ); 

    }
}
