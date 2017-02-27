using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discScript : MonoBehaviour {

	public Rigidbody rb;
	public float force;

	// Use this for initialization
	void Start () {
		force = 10.0F;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			rb.AddForce (transform.right * force, ForceMode.Impulse);
		}
	}
}
