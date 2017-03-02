using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.ootii.Cameras;
using com.ootii.Input;

public class gameController : MonoBehaviour {

	public GameObject[] allPieces;
	public GameObject currentObject;
	public GameObject nextObject;
	public GameObject indicatorArrow;
	public Rigidbody rb;
	public int currentIndex;
	public int nextIndex;
	public float transitionDuration;
	public CameraController camController;
	public float shotStrength;




	// Use this for initialization
	void Start () {
		indicatorArrow = GameObject.FindGameObjectWithTag ("arrow");
		shotStrength = 400.0f;
		allPieces = GameObject.FindGameObjectsWithTag ("pieces");
		currentIndex = 0;
		currentObject = allPieces [currentIndex];
		if (allPieces != null) {
		}
		else {
			Debug.Log ("no pieces found");
		}

	}
	
	// Update is called once per frame
	void Update () {
		currentObject = allPieces[currentIndex];
		if (InputManager.IsJustPressed ("ChargeShot")) {
			rb.AddForce (indicatorArrow.transform.forward * -shotStrength, ForceMode.Impulse);
			
		}

		if(InputManager.IsJustPressed("CameraPanButtons")) {
			Debug.Log("Switching to pan mode");
		}



	}
				
		
}
