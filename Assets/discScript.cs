using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discScript : MonoBehaviour {

	public Rigidbody rb;
	public float force;
	public Vector3 mousePos;
	public Vector3 worldMousePos;
	public Camera cam;
	private bool charging;
	public float torqueForce;

	// Use this for initialization
	void Start () {
		cam = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera>();
		rb = GetComponent<Rigidbody> ();
		charging = false;
		force = 15.0F;
		torqueForce = 30.0F;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
			mousePos = Input.mousePosition;
			Vector3 screenTransform = cam.WorldToScreenPoint (transform.position);

			Debug.Log ("mousePos.x: " + mousePos.x + " mousePos.y: " +  mousePos.y + " mousePos.z: " + mousePos.z);
			Debug.Log ("screenTransform.x: " + screenTransform.x + " screenTransform.y: " +  screenTransform.y + " screenTransform.z: " +screenTransform.z);
			Debug.Log ("\nstransform.x: " + transform.position.x + " transform.y: " + transform.position.y + " transform.z: " + transform.position.z);

			Vector3 diff;
			diff.x = screenTransform.x - mousePos.x;
			diff.y = transform.position.y;
			diff.z = screenTransform.y - mousePos.y;
			rb.AddForce (diff.normalized * force, ForceMode.Impulse);
			rb.AddTorque (transform.up * torqueForce, ForceMode.Impulse);


		}
	}
}
