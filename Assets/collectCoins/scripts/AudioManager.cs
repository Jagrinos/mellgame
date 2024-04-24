using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource _amAm;
    [SerializeField] AudioSource _minusHp;
    public void PlayAmAm()
    {
        _amAm.Play();
    }
    public void PlayMinusHp()
    {
        _minusHp.Play();
    }
}
