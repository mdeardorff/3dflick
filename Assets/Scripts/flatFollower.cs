using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flatFollower : MonoBehaviour {
	public GameObject anchor;
	public gameController controller;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		anchor = controller.currentObject;
		
		transform.position = anchor.transform.position;
		transform.rotation = new Quaternion (0, 0, 0, 0);
		
	}
}
