using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge_Manager : MonoBehaviour
{
    public Vector3 endPosition;
    public float speed;
    private LineRenderer lineRenderer;
    private bool IsEnable = false;

    public void SetLinePosition(Vector3 _startPosition, Vector3 _endPosition)
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, _startPosition);
        lineRenderer.SetPosition(1, _startPosition);
        endPosition = _endPosition;
        IsEnable = true;
    }

    private void Update()
    {
        if (IsEnable && lineRenderer.GetPosition(1) != endPosition) lineRenderer.SetPosition(1, Vector3.Lerp(lineRenderer.GetPosition(1), endPosition, speed));
    }
}
