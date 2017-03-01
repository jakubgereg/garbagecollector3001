using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public KeyCode Left;
    public KeyCode Right;
    public float movementSpeed;
    public float maxVelocity;

    Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        
		if(Input.GetKey(Left))
        {
            transform.position += new Vector3(-movementSpeed,0) * Time.deltaTime;
        }
	}
}
