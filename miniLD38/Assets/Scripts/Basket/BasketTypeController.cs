using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTypeController : MonoBehaviour {

    public ColorType type;

    LivesController livesController;
    ScoreController scoreController;

	void Start () {
        livesController = GameObject.FindGameObjectWithTag("GameController").GetComponent<LivesController>();
        scoreController = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreController>();

    }
	
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        GameObject box = coll.gameObject;
        BoxType boxType = box.GetComponent<BoxType>();

        if (type != boxType.type)
        {
            livesController.getHit();
            print("wrong box");
        }
        else
        {
            scoreController.addScorePoint();
            print("right box");
        }
    }
}
