using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BezierTest : MonoBehaviour
{
    [SerializeField] Transform p0;
    [SerializeField] Transform p1;
    [SerializeField] Transform p2;
    [SerializeField] Transform p3;

    [Range(0, 1)]
    [SerializeField] float t;
    [SerializeField] float tSpeed;

    private Vector3 Zcoord = new Vector3(0f,0f,0f);
   

    private void Start()
    {
        gameObject.transform.position = p0.transform.position;
    }

    private void LateUpdate()
    {
        t += tSpeed * Time.deltaTime;

        transform.position = Bezier.GetPoint(p0.position, p1.position, p2.position, p3.position, t);

        

        if(transform.position.x < 7.30f)
        {
            Zcoord += new Vector3(0f, 0f, 0.015f);
            
            if(transform.position.x > 5)
            {
                Zcoord += new Vector3(0f, 0f, 0.02f);
            }
        }
        

        transform.eulerAngles = Zcoord;
    }

    
}
