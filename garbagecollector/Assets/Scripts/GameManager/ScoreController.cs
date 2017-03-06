using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

    public int ActualScore
    {
        get; set;
    }

    void Start()
    {
        ActualScore = 0;
    }

    void Update()
    {

    }

    public void addScorePoint()
    {
        ActualScore++;
    }
}
