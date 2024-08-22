using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Vertex_Manager : MonoBehaviour
{
    public GameObject numberText;
    public void SetInstanceState(int number, Vector3 position)
    {
        gameObject.transform.position = position;
        numberText.GetComponent<TextMeshPro>().text = number.ToString();
    }
}
