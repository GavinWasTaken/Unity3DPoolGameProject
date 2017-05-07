using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float force = 1;
	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * force);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
