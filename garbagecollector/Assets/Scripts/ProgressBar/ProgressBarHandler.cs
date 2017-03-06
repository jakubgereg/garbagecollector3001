using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBarHandler : MonoBehaviour {

    ClickProgressManager progressManager;

    Vector3 startScale;

	void Start () {
        startScale = transform.localScale;
        progressManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<ClickProgressManager>();	
	}
	
	void Update () {
        transform.localScale = new Vector3(startScale.x,getActualYScale());
        
    }

    float getActualYScale()
    {
        return startScale.y * (progressManager.GetPercentageAmount()/100);
    }
}
