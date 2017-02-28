using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

	public GameObject[] allPieces;
	public GameObject currentObject;
	public GameObject nextObject;
	public int currentIndex;
	public int nextIndex;
	public bool atDestination = true;
	public cameraFollow followScript;
	public cameraLerp lerpScript;

	// Use this for initialization
	void Start () {
		allPieces = GameObject.FindGameObjectsWithTag ("pieces");
		currentObject = allPieces [0]; 
		currentIndex = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentObject = allPieces [currentIndex];

			if (Input.GetKeyDown (KeyCode.D)) {
				if(currentIndex + 1 < allPieces.Length - 1) nextIndex = currentIndex++;
				if (currentIndex > allPieces.Length - 1) {
					nextIndex = 0;
				}
				atDestination = !atDestination;
				nextObject = allPieces [nextIndex];
				Debug.Log ("D pressed");
				StartCoroutine (lerpScript.Transition ());
					
			} else if (Input.GetKeyDown (KeyCode.A)) {
				if(currentIndex - 1 >= 0) nextIndex = currentIndex--;
				if (currentIndex < 0) {
					nextIndex = allPieces.Length - 1;
				}
				atDestination = !atDestination;
				nextObject = allPieces [nextIndex];
				Debug.Log ("A pressed");
				StartCoroutine (lerpScript.Transition ());
			}


		}
		
}
