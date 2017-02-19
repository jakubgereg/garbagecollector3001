using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugClickCounter : MonoBehaviour {

    Text clickCount;
    ClickController click;

    void Start () {
        click = GameObject.FindGameObjectWithTag("GameController").GetComponent<ClickController>();
        clickCount = GetComponent<Text>();
	}
	
	void Update () {
        clickCount.text = ClickController.clickCount.ToString();//click.clickCount.ToString();
	}
}
