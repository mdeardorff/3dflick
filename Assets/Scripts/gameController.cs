using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.ootii.Cameras;
using com.ootii.Input;

public class gameController : MonoBehaviour {

	public GameObject[] allPieces;
	public GameObject currentObject;
	public GameObject nextObject;
	public int currentIndex;
	public int nextIndex;
	public bool atDestination;
	public cameraFollow followScript;
	public float transitionDuration;
	public CameraController camController;
	public bool shouldTransition;




	// Use this for initialization
	void Start () {
		
		atDestination = true;
		allPieces = GameObject.FindGameObjectsWithTag ("pieces");
		if (allPieces != null) {
			currentIndex = 0;
			nextIndex = 1;
			currentObject = allPieces [currentIndex]; 
		}
		else {
			Debug.Log ("no pieces found");
		}

	}
	
	// Update is called once per frame
	void Update () {

		if(InputManager.IsJustPressed("CameraPanButtons")) {
			Debug.Log("Switching to pan mode");
		}



	}
				
		
}
