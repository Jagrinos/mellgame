using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public float CoinSpeed;

    public void CoinMove(GameObject coin)
    {
        coin.transform.position -= new Vector3(0, CoinSpeed * Time.deltaTime, 0);
    }
}
