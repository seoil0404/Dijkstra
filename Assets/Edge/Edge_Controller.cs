using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge_Controller : MonoBehaviour
{
    public GameObject edgePrefab;
    public Vertex_Controller vertex;
    public GameObject GenerateEdge(int startNum, int endNum)
    {
        GameObject edge = Instantiate(edgePrefab);
        edge.GetComponent<Edge_Manager>().SetLinePosition(vertex.GetVertexPosition(startNum), vertex.GetVertexPosition(endNum));
        return edge;
    }

}
