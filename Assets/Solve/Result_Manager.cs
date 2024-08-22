using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Result_Manager : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Awake()
    {
        solve solve_manager = GameObject.Find("Solve_Manager").GetComponent<solve>();
        ShowResult(solve_manager.dp);
    }
    public void ShowResult(int[] result)
    {
        text.text = null;
        for(int i = 0; i < result.Length; i++)
        {
            if (result[i] == -1) text.text += "INF\n";
            else text.text += result[i] + "\n";
        }
    }
}
