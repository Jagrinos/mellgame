using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FactorManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    public float _scale;
    private float _scaleChanger = 0.0001f;

    private float nextActionTime = 1.0f;
    private float period = 1f;

    private double currentTime;

    void Start()
    {
        _text.text = _scale.ToString() + "X";
    }


    private void LateUpdate()
    {
        _scale += _scaleChanger;

        currentTime += Time.deltaTime;

        if (currentTime > nextActionTime)
        {
            nextActionTime += period;

            _scaleChanger += 0.001f;
        }


        _text.text = _scale.ToString("F2") + "X";
    }




}
