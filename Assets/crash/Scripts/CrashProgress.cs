using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashProgress : MonoBehaviour
{
    public static CrashProgress Instance;

    public float progressMoney;
    
    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
