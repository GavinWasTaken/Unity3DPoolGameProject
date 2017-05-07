using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPotted : MonoBehaviour {
    public Vector3 spawnPoint;
    gameManager manager;
    public AudioSource applause;
    public GameObject wbs;
    
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "RedBall")
        {
            applause.Play();
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "BlueBall")
        {
            applause.Play();
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "BlackBall")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "WhiteBall")
        {
            var hitcolliders = Physics.OverlapSphere(spawnPoint, 1);
            if (hitcolliders.Length <= 0)
            {

                other.gameObject.transform.position = wbs.transform.position;
                other.GetComponent<Rigidbody>().velocity = Vector3.zero;
                gameManager.turns = 2;
            }
        }
    }
}
