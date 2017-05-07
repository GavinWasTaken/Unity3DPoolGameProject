using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLine : MonoBehaviour {
    public LineRenderer aimline;
    public float linewidth = 0.1f;
    public float linelength = 5f;
	// Use this for initialization
	void Start () {
        Vector3[] initPositions = new Vector3[2] { Vector3.zero, Vector3.zero };
        aimline.SetPositions(initPositions);
        aimline.SetWidth(linewidth, linewidth);
	}
	
	// Update is called once per frame
	void Update () {
        aimlineTargetPosition(transform.position, Vector3.forward, linewidth);
        aimline.enabled = true;
	}

    void aimlineTargetPosition(Vector3 targetPosition, Vector3 direction, float length)
    {
        Ray ray = new Ray(targetPosition, direction);
        RaycastHit raycastHit;
        Vector3 endPosition = targetPosition + (length * direction);

        if(Physics.Raycast(ray, out raycastHit, length))
        {
            endPosition = raycastHit.point;
        }

        aimline.SetPosition(0, targetPosition);
        aimline.SetPosition(1, endPosition);
    }
}
