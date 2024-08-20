using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertex_Generator : MonoBehaviour
{
    public GameObject vertexPrefab;

    [Range(0, 10f)]
    public float density = 1f;

    public float initRadius = 0f;
    float lineDensity = 0.45f;
    float angleGrowthRate = 5f;
    float angle = 0f;

    public GameObject GenerateSingleVertex(int number)
    {
        GameObject newVertex = Instantiate(vertexPrefab);
        newVertex.GetComponent<Vertex_Manager>().Instance(number, GenerateVertexPosition());
        
        return newVertex;
    }

    Vector3 GenerateVertexPosition()
    {
        float radius = initRadius + lineDensity * angle;
        angle += angleGrowthRate / (1+radius);

        float x = radius * Mathf.Sin(angle);
        float y = radius * Mathf.Cos(angle);
        
        return new Vector3(x, y, 0);
    }

    private void Awake()
    {
        initRadius *= density;
        lineDensity *= density;
        angleGrowthRate *= density;
    }

    
}
