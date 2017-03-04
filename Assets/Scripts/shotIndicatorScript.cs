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
	private Vector3 offset;
	public Transform correctOrientation;

	// Use this for initialization
	void Start () {
		meshRender = gameObject.GetComponentsInChildren<MeshRenderer> ();
		isActive = true;
		rotationSpeed = 2.0f;
		offset = controller.currentObject.transform.position - transform.position;
		transform.position = controller.currentObject.transform.position + offset;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position != controller.currentObject.transform.position + offset)
			transform.position = controller.currentObject.transform.position - offset;
		
		if (rb.velocity == Vector3.zero) {
			isActive = true;
		} else
			isActive = false;

		if (isActive) {
			if (controller.currentObject.transform.rotation != correctOrientation.transform.rotation) {
				controller.currentObject.transform.rotation = correctOrientation.transform.rotation;
			}
			meshRender[0].enabled = true;
			meshRender [1].enabled = true;
			if (InputManager.IsPressed ("RotateShotIndicatorRight")) {
				transform.RotateAround (controller.currentObject.transform.position, controller.currentObject.transform.up, rotationSpeed);
			}
			if (InputManager.IsPressed ("RotateShotIndicatorLeft")) {
				transform.RotateAround (controller.currentObject.transform.position, controller.currentObject.transform.up, -rotationSpeed);
			}
			offset = controller.currentObject.transform.position - transform.position;
		} else {
			meshRender [0].enabled = false;
			meshRender [1].enabled = false;
			transform.position = controller.currentObject.transform.position - offset;

		}
		
	}
}
