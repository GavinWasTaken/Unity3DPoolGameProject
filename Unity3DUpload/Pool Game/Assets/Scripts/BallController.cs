using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public Transform cueObj;
    public float appliedForce;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

        if(Input.GetKey("a"))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, -1, 0);
        }

        

        if (GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            
            var check = GameObject.Find("PivotPoint");
            var check2 = GameObject.Find("PivotPoint(Clone)");
            if (check == null && check2 == null)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                Instantiate(cueObj, transform.position, cueObj.rotation);
            }
            

        }
	}
}
