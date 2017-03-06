using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugClickCounter : MonoBehaviour {

    Text clickCount;

    void Start () {
        clickCount = GetComponent<Text>();
	}
	
	void Update () {
        clickCount.text = ClickController.clickCount.ToString();//click.clickCount.ToString();
	}
}
