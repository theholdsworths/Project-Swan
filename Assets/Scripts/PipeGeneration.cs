using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGeneration : MonoBehaviour
{
    public GameObject pipeObstacles;
    int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacles", 1f, 1.5f);
        //InvokeRepeating("CreateObstacles", Random.Range(1f, 2f), Random.Range(1.5f, 2.5f));
    }

    private void OnGUI()
    {
        GUILayout.Label(" Points: " + points.ToString());
    }

    void CreateObstacles()
    {
        Instantiate(pipeObstacles);
        points++;
    }
}
