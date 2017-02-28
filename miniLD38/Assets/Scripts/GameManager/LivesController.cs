using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesController : MonoBehaviour {

    public int numberOfLives;

    public string gameOverSceneName;

	void Start () {
		
	}
	
	void Update () {
        if(numberOfLives <=0)
        {
            callGameOver();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public void getHit()
    {
        numberOfLives--;
    }

    void callGameOver()
    {
        ScoreController sc = GetComponent<ScoreController>();
        DataContainer.score = sc.ActualScore;
        Invoke("gameOver", 0.5f);
        
    }

    void gameOver()
    {
        SceneManager.LoadScene(gameOverSceneName);
    }
}
