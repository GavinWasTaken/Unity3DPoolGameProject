using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CueShot : MonoBehaviour {
    public float appliedForce;
    public gameManager manager;
    public Text forceAmount;
    void Start () {
        forcetotext();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody>().AddRelativeForce(0, 0, appliedForce);
            forcetotext();

        }
        if (Input.GetKeyDown("w"))
        {
            if (appliedForce > 3500)
            {
                appliedForce = appliedForce;

            }
            else
            {
                appliedForce += 200f;
                
            }
            
        }
        if (Input.GetKeyDown("s"))
        {
            if(appliedForce < 300)
            {
                appliedForce = appliedForce;
                
            }
            else
            {
                appliedForce -= 200;
                //cue.transform.position += new Vector3(0, 0, 0.1f);
            }
            
        }

    }
    private void FixedUpdate()
    {
        forcetotext();
    }
    void forcetotext()
    {
        if (appliedForce >= 300)
        {
            forceAmount.text = " Force Level: minimum";
        }
        
        if (appliedForce >= 500)
        {
            forceAmount.text = " Force Level: light tap";
        }
        
        if (appliedForce >= 700)
        {
            forceAmount.text = " Force Level: average tap";
        }
        
        if (appliedForce >= 900)
        {
            forceAmount.text = " Force Level: heavy tap";
        }
        
        if (appliedForce >= 1100)
        {
            forceAmount.text = " Force Level: light stroke";
        }
        
        if (appliedForce >= 1300)
        {
            forceAmount.text = " Force Level: average stroke";
        }
        
        if (appliedForce >= 1500)
        {
            forceAmount.text = " Force Level: heavy stroke";
        }
        
        if (appliedForce >= 1700)
        {
            forceAmount.text = " Force Level: light hit";
        }
        
        if (appliedForce >= 1900)
        {
            forceAmount.text = " Force Level: average hit";
        }
        
        if (appliedForce >= 2100)
        {
            forceAmount.text = " Force Level: heavy hit";
        }
        
        if (appliedForce >= 2300)
        {
            forceAmount.text = " Force Level: light strike";
        }
        
        if (appliedForce >= 2500)
        {
            forceAmount.text = " Force Level: average strike";
        }
        
        if (appliedForce >= 2700)
        {
            forceAmount.text = " Force Level: heavy strike";
        }
        
        if (appliedForce >= 2900)
        {
            forceAmount.text = " Force Level: light smash";
        }
        
        if (appliedForce >= 3100)
        {
            forceAmount.text = " Force Level: average smash";
        }
        
        if (appliedForce >= 3300)
        {
            forceAmount.text = " Force Level: heavy smash";
        }
        
        if (appliedForce >= 3500)
        {
            forceAmount.text = " Force Level: max";
        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "WhiteBall")
        {
            Destroy(transform.parent.gameObject);
            Destroy(gameObject);
        }
        
    }
}
