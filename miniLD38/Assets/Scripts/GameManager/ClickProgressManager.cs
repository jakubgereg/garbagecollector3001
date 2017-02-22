using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickProgressManager : MonoBehaviour {

    #region editor fields
    public float ResourcesPerClick;
    public float ResourcesDecreaseSpeed;
    public float MaxResourcesAmount;
    #endregion

    public GameObject GameOverText;

    public static float ActualResourcesAmount;

    void Start () {
        ActualResourcesAmount = 0;
	}
	
	void Update () {
        clampResources();

        if(ActualResourcesAmount > 0)
        {
            ActualResourcesAmount -= ResourcesDecreaseSpeed * Time.deltaTime;
        }
        if(ClickController.GameStarted && ActualResourcesAmount <= 0)
        {
            GameOverText.SetActive(true);
        }
	}

    public void AddResources()
    {
        ActualResourcesAmount += ResourcesPerClick;
    }

    public float GetPercentageAmount()
    {
        return (100 / MaxResourcesAmount) * ActualResourcesAmount;
    }

    void clampResources()
    {
        if (ActualResourcesAmount > MaxResourcesAmount)
        {
            ActualResourcesAmount = MaxResourcesAmount;
        }
        if (ActualResourcesAmount < 0)
            ActualResourcesAmount = 0;
    }


}
