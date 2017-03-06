using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButtonController : MonoBehaviour {

    public string gameSceneName;
    public Button retryButton;

	void Start () {
        retryButton.interactable = false;
        Invoke("setButtonActive",1.5f);		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playAgain()
    {
        SceneManager.LoadScene(gameSceneName);
        DataContainer.score = 0;
    }

    void setButtonActive()
    {
        retryButton.interactable = true;
    }
}
