using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMovingCamera : MonoBehaviour {
    public Transform ballObj;
    public float distance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        //transform.position = new Vector3(ballObj.transform.position.x + distance, ballObj.transform.position.y + distance, ballObj.transform.position.z);
        transform.RotateAround(ballObj.position, ballObj.position, 0);
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, ballObj.GetComponent<Rigidbody>().velocity.z);
	}
}
