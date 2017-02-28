using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	// Use this for initialization
	public Vector3 offset;
	public GameObject target;


	void Start () {
		offset.x = -10.0F;
		offset.y = 7.0F;
		offset.z = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = target.transform.position + offset;
	}

	Vector3 getOffset() {
		return offset;
	}
		
}
