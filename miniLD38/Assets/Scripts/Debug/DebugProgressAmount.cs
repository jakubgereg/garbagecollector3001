using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugProgressAmount : MonoBehaviour {

    Text progressText;

    void Start () {
        progressText = GetComponent<Text>();	
	}
	
	void Update () {
        progressText.text = ClickProgressManager.ActualResourcesAmount.ToString("0.0");
	}
}
