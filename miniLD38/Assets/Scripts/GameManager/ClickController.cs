using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour {

    public static int clickCount = 0;
    public static bool GameStarted;

    void Awake()
    {
        GameStarted = false;
        clickCount = 0;
    }

    #region UI button methods
    public void ButtonClick()
    {
        clickCount++;
    }

    public void firstClick()
    {
        GameStarted = true;
    }
    #endregion
}
