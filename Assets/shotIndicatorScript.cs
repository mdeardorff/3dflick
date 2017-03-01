using System.Collections;
using System.Collections.Generic;
using com.ootii.Input;
using com.ootii.Utilities;
using UnityEngine;

public class shotIndicatorScript : MonoBehaviour {
	public bool isActive;
	public gameController controller;
	public Rigidbody rb;
	public float rotationSpeed;
	public MeshRenderer[] meshRender;

	// Use this for initialization
	void Start () {
		meshRender = gameObject.GetComponentsInChildren<MeshRenderer> ();
		isActive = true;
		rotationSpeed = 2.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (rb.velocity == Vector3.zero) {
			isActive = true;
		} else
			isActive = false;

		if (isActive) {
			meshRender[0].enabled = true;
			meshRender [1].enabled = true;
			if (InputManager.IsPressed ("RotateShotIndicatorRight")) {
				transform.RotateAround (controller.currentObject.transform.position, controller.currentObject.transform.up, rotationSpeed);
			}
			if (InputManager.IsPressed ("RotateShotIndicatorLeft")) {
				transform.RotateAround (controller.currentObject.transform.position, controller.currentObject.transform.up, -rotationSpeed);
			}
		} else {
			meshRender [0].enabled = false;
			meshRender [1].enabled = false;
			transform.position = transform.position + rb.velocity * Time.deltaTime;

		}
		
	}
}
