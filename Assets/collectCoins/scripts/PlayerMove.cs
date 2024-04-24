using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _playerSpeed;
    ButtonManager ButtonManager;

    void Start()
    {
        ButtonManager = FindAnyObjectByType<ButtonManager>();
    }
    void Update()
    {
        if (ButtonManager.StartGame)
        {
            float dir = Input.GetAxis("Horizontal");

            if (dir > 0)
                transform.Find("car").rotation = new Quaternion(0, 0,0, transform.rotation.w);
            
            if (dir < 0)
                transform.Find("car").rotation = new Quaternion(0, 180, 0, transform.rotation.w);

            if (dir != 0)
            {
                if (transform.position.x > -8 && transform.position.x < 8)
                    transform.position += new Vector3(dir * _playerSpeed * Time.deltaTime, 0, 0);
                else
                {
                    if (transform.position.x < -8)
                        transform.position = new Vector3(-7.9f, transform.position.y, transform.position.z);
                    if (transform.position.x > 8)
                        transform.position = new Vector3(7.9f, transform.position.y, transform.position.z);
                }
            }

        }
    }


}
