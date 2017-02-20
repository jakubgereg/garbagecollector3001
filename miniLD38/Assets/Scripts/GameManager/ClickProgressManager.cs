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
        clampResources();

        if(actualResourcesAmount > 0)
        {
            actualResourcesAmount -= ResourcesDecreaseSpeed * Time.deltaTime;
        }
        
	}

    public void AddProgress()
    {
        actualResourcesAmount += ResourcesPerClick;
    }

    public float GetPercentageAmount()
    {
        return (100 / MaxResourcesAmount) * actualResourcesAmount;
    }

    void clampResources()
    {
        if (actualResourcesAmount > MaxResourcesAmount)
        {
            actualResourcesAmount = MaxResourcesAmount;
        }
        if (actualResourcesAmount < 0)
            actualResourcesAmount = 0;
    }
}
