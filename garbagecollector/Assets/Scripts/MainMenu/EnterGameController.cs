using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterGameController : MonoBehaviour {

    public InputField nicknameField;
    public string gameSceneName;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startNewGame()
    {
        DataContainer.nickName = nicknameField.text;
        DataContainer.score = 0;
        /*
        if(gameSceneName == "")
        {
            Debug.LogWarning("Please specify scene name to load in " + gameObject.name);
            return;
        }*/
        SceneManager.LoadScene(gameSceneName);


    }
}
