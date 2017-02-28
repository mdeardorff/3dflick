using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	// Use this for initialization
	public Vector3 offset;
	public GameObject target;
	public bool inactive;


	void Start () {
		offset.x = -10.0F;
		offset.y = 7.0F;
		offset.z = 0.0f;
		inactive = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!inactive) {
			transform.position = target.transform.position + offset;
		}
	}
		
}
