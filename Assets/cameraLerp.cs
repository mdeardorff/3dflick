using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLerp : MonoBehaviour {

	public Transform startMarker;
	private float startTime;
	private float journeyLength;
	public gameController controller;
	public cameraFollow follower;
	private float distCovered;
	private float fracJourney;
	public float transitionDuration = 0.5f;

	// Use this for initialization
	void Start () {
		
	}

	public IEnumerator Transition() {

		float t = 0.0f;
		if(t == 0.0f) Debug.Log ("transition started. StartPosition: " + transform.position + " EndPosition: " +  (controller.nextObject.transform.position + follower.offset));
		controller.atDestination = false;

		Vector3 startingPos = transform.position;
		while (t < 1.0f) {
			t += Time.deltaTime * (Time.timeScale / transitionDuration);
			transform.position = Vector3.Lerp (startingPos, controller.nextObject.transform.position + follower.offset, t);
			yield return 0;
		}
		if(t == 1.0f) Debug.Log ("transition started. StartPosition: " + transform.position + " EndPosition: " +  (controller.nextObject.transform.position + follower.offset));
		if(t >= 1.0f) {
			controller.currentObject = controller.nextObject;
			follower.target = controller.currentObject;
		}




	}


	
	// Update is called once per frame
	void Update () {
			
		
	}
}
