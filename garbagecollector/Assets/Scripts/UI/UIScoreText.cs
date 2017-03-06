using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : MonoBehaviour {

    public ScoreController scoreController;

    Text onScreenText;

    void Start () {
        onScreenText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
       onScreenText.text = "Score: " + scoreController.ActualScore.ToString();

    }
}
