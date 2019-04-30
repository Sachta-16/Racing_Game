using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{

    private int points;
    public int Points
    {
        get
        {
            
            return points;
        }
        set
        {
            
            points = value;
        }
    }

    Text scoreCount;// = GameObject.Find("ScoreCount").GetComponent<Text>();

    private void Start()
    {
        scoreCount = GameObject.Find("ScoreCount").GetComponent<Text>();
    }

    private void Update()
    {
        if (Points > 0)
        {
            scoreCount.text = Points.ToString();
        }
    }
}
