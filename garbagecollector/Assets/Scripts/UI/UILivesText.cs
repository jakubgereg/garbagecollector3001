using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILivesText : MonoBehaviour {

    public LivesController livesController;

    Text onScreenText;

	void Start () {
        onScreenText = GetComponent<Text>();
    }
	
	void Update () {
        onScreenText.text = "Number of lives: " + livesController.numberOfLives.ToString();
	}   
}
