using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickProgressManager : MonoBehaviour {

    #region editor fields
    public float ResourcesPerClick;
    public float ResourcesDecreaseSpeed;
    public float MaxResourcesAmount;
    #endregion

    public static float actualResourcesAmount;

    void Start () {
        actualResourcesAmount = 0;
	}
	
	void Update () {
        if(actualResourcesAmount > 0)
        {
            actualResourcesAmount -= ResourcesDecreaseSpeed * Time.deltaTime;
        }
        if(actualResourcesAmount > MaxResourcesAmount)
        {
            actualResourcesAmount = MaxResourcesAmount;
        }

	}

    public void AddProgress()
    {
        actualResourcesAmount += ResourcesPerClick;
    }
}
