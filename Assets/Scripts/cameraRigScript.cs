using System.Collections;
using System.Collections.Generic;
using com.ootii.Cameras;
using UnityEngine;

public class cameraRigScript : MonoBehaviour {
	public CameraController camController;
	public gameController controller;

	// Use this for initialization
	void Start () {
		controller = GameObject.FindGameObjectWithTag ("GameController").GetComponent<gameController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		camController.Anchor = controller.currentObject.transform;	
	}
}
