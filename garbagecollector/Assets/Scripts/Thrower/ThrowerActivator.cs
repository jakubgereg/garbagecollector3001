using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerActivator : MonoBehaviour {

    public float MaxYpos;
    public float ThrowerSpeed;

    Vector3 startPos;
    Vector3 destination;

    bool activated;



	void Start () {
        startPos = transform.position;
	}
	
	void Update () {
		if(activated)
        {
            transform.position = Vector3.MoveTowards(transform.position,destination,ThrowerSpeed*Time.deltaTime);
        }
	}


    public void activate()
    {
        if (activated)
            return;
        activated = true;
        destination = new Vector3(transform.position.x,transform.position.y + MaxYpos);
    }
}
