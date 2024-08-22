using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertex_Generator : MonoBehaviour
{
    public GameObject vertexPrefab;

    public float AngleGrowthRate;

    private float Growth = 0f;
    private float angle = 1.5f;

    public GameObject GenerateSingleVertex(int number)
    {
        GameObject newVertex = Instantiate(vertexPrefab);
        newVertex.GetComponent<Vertex_Manager>().SetInstanceState(number, GenerateVertexPosition());
        
        return newVertex;
    }

    Vector3 GenerateVertexPosition()
    {
        float x = angle * AngleGrowthRate * Mathf.Sin(angle);
        float y = angle * AngleGrowthRate * Mathf.Cos(angle);

        Growth+=3 * AngleGrowthRate;
        angle = Mathf.Sqrt(Growth);

        return new Vector3(x, y, 0);
    }

    private void Awake()
    {

    }

    
}
