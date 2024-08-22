using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void GotoStartScene()
    {
        GameObject data = GameObject.Find("Data_Manager");
        GameObject solve = GameObject.Find("Solve_Manager");
        Destroy(data);
        Destroy(solve);
        SceneManager.LoadScene("StartScene");
    }
}
