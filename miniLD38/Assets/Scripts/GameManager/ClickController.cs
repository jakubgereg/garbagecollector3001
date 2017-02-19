using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour {

    public static int clickCount = 0;

    void Awake()
    {
        clickCount = 0;
    }

    public void ButtonClick()
    {
        clickCount++;
    }
}
