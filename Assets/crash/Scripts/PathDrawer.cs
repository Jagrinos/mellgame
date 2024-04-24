using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathDrawer : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer; 
    [SerializeField] float pointSpacing = 0.1f; 

    private List<Vector3> pathPoints = new List<Vector3>(); 

    void Start()
    {
        lineRenderer.positionCount = 0;
    }

    void Update()
    {
        if (pathPoints.Count == 0 || Vector3.Distance(pathPoints[pathPoints.Count - 1], transform.position) > pointSpacing)
        {
            pathPoints.Add(transform.position);

            lineRenderer.positionCount = pathPoints.Count;
            lineRenderer.SetPositions(pathPoints.ToArray());
        }
    }
}
