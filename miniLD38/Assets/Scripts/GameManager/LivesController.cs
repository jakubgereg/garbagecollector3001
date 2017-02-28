using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour {

    public int numberOfLives;

	void Start () {
		
	}
	
	void Update () {
        print(numberOfLives);
        if(numberOfLives <=0)
        {
            callGameOver();
        }
	}

    public void getHit()
    {
        numberOfLives--;
    }

    void callGameOver()
    {
        print("game over");
    }
}
