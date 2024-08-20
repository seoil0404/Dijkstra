using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Data_Manager : MonoBehaviour
{
    private const int MAIN_SCENE_NUMBER = 1;

    public int start_vertex;
    public priority_queue<Vector2>[] vertex_data;

    public TMP_InputField field;
    
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void EndInput()
    {
        string temp = field.text;
        string[] text = temp.Split('\n');

        string[] backGroundData = text[0].Split(" ");

        int V = int.Parse(backGroundData[0]);
        int E = int.Parse(backGroundData[1]);
        
        vertex_data = new priority_queue<Vector2>[V];

        for(int i = 0; i < V; i++)
        {
            vertex_data[i] = new priority_queue<Vector2>();
        }

        start_vertex = int.Parse(text[1])-1;

        for(int i = 0; i < E; i++)
        {
            string[] tempVertexData = text[i+2].Split(" ");
            
            int u = int.Parse(tempVertexData[0]);
            int v = int.Parse(tempVertexData[1]);
            int w = int.Parse(tempVertexData[2]);

            vertex_data[u-1].push(new Vector2(v-1, w), w);
        }
        SceneManager.LoadScene(MAIN_SCENE_NUMBER);
    }
}