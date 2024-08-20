using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Graph_Controller : MonoBehaviour
{
    public Vertex_Controller vertex;
    public Edge_Controller edge;
    public DynamicEdge_Controller dynamicEdge;
    public Camera_Manager cameraManager;

    public GameObject costPrefab;
    public TextMeshPro[] costText;

    private void Start()
    {
        
    }

    public void GenerateVertexCost(int vertexNumber, int cost)
    {
        if (costText[vertexNumber] == null)
        {
            GameObject temp = Instantiate(costPrefab);
            temp.GetComponent<Vertex_Cost_Manager>().GenerateMinCost(cost, vertex.GetVertexPosition(vertexNumber));
            costText[vertexNumber] = temp.GetComponent<TextMeshPro>();
        }
        else
        {
            costText[vertexNumber].text = cost.ToString();
        }
        
    }

    public void GenerateDynamicEdge(int startNum, int endNum)
    {
        dynamicEdge.GenerateEdge(startNum, endNum);
        cameraManager.position = vertex.GetVertexPosition(endNum);
    }

    public void GenerateGraph(priority_queue<Vector2>[] data)
    {
        costText = new TextMeshPro[data.Length];
        vertex.GenerateVertex(data.Length);

        for(int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data[i].size(); j++)
            {
                edge.GenerateEdge(i, (int)data[i][j].x);
            }
        }
    }

    private void Update()
    {
        
    }
}
