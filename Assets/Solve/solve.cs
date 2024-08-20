using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solve : MonoBehaviour
{
    public Vertex_Controller vertex_controller;
    public Graph_Controller graph_controller;
    public bool isContinue;
    private void Awake()
    {
        isContinue = true;
        Data_Manager data_manager = GameObject.Find("Data_Manager").GetComponent<Data_Manager>();
        graph_controller.GenerateGraph(data_manager.vertex_data);
        StartCoroutine(Solve(data_manager.vertex_data, data_manager.start_vertex));
    }
    //-------------------------------------------------------------------------------------------

    private int[] dp;

    public void Continue()
    {
        isContinue=true;
    }

    IEnumerator Solve(priority_queue<Vector2>[] data, int start_vertex)
    {
        dp = new int[data.Length];

        for (int i = 0; i < data.Length; i++)
        {
            dp[i] = -1;
        }

        Queue<int> node = new Queue<int>();
        node.Enqueue(start_vertex);
        graph_controller.GenerateVertexCost(0, 0);
        dp[start_vertex] = 0;
        while (node.Count != 0)
        {
            int front = node.Dequeue();
            for (int i = 0; i < data[front].size(); i++)
            {
                Vector2 v = data[front][i];

                int force = (int)v.x;
                int cost = (int)v.y;

                int temp = dp[front] + cost;

                bool flag1 = dp[force] == -1;
                bool flag2 = dp[force] != 0 && dp[force] > temp;

                if (flag1 || flag2)
                {
                    yield return new WaitUntil(() => isContinue);
                    isContinue = false;

                    node.Enqueue(force);
                    dp[force] = temp;
                    graph_controller.GenerateVertexCost(force, dp[force]);
                    graph_controller.GenerateDynamicEdge(front, force);
                }
            }
        }
        for (int i = 0; i < dp.Length; i++)
        {
            if (dp[i] == -1) Debug.Log("INF");
            else Debug.Log(dp[i]);
        }
    }

    public int Wait()
    {
        return 1;
    }
}
