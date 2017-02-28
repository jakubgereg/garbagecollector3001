using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonController : MonoBehaviour {

    public string gameSceneName;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playAgain()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
