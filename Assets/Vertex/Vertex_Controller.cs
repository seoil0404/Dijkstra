using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Vertex_Controller : MonoBehaviour
{
    GameObject[] vertex;
    Vertex_Generator generator;

    private void Awake()
    {
        generator = GetComponent<Vertex_Generator>();
    }

    public void GenerateVertex(int amount)  
    {
        vertex = new GameObject[amount];

        for(int i = 1; i <= amount; i++)
        {
            vertex[i-1] = generator.GenerateSingleVertex(i);
        }
    }

    public Vector3 GetVertexPosition(int number)
    {
        return vertex[number].transform.position;
    }
}
