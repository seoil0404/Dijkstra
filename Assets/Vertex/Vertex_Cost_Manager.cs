using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vertex_Cost_Manager : MonoBehaviour
{
    public float tray_Y;
    public void GenerateMinCost(int cost, Vector3 position)
    {
        this.GetComponent<TextMeshPro>().text = cost.ToString();
        this.transform.position = new Vector3(0, tray_Y, 0) + position;
    }
}
