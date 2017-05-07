using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {
    public float velocityShown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        velocityShown = GetComponent<Rigidbody>().velocity.magnitude;
        
    }
    void FixedUpdate()
    {
        if(GetComponent<Rigidbody>().velocity.magnitude <= 0.1f)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            
        }
    }
}
