using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMoveController : MonoBehaviour {
	public float moveSpeed;
	public float rotateSpeed;
	public GameObject flatReference;
	public GameObject target;

	// Use this for initialization
	void Start () {
		rotateSpeed = 1.3f;
		moveSpeed = .6f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
			transform.RotateAround (target.transform.position, target.transform.up, -rotateSpeed);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.RotateAround (target.transform.position, target.transform.up, rotateSpeed);
		}

		if (Input.GetKey (KeyCode.W)) {
			if (Vector3.MoveTowards (transform.position, target.transform.position, moveSpeed).y > (7.0f - moveSpeed)) {
				transform.position = Vector3.MoveTowards (transform.position, target.transform.position, moveSpeed);
			}
		}

		if (Input.GetKey (KeyCode.S)) {
			if (Vector3.MoveTowards (transform.position, target.transform.position, moveSpeed).y < (10.0f - moveSpeed)) {
				transform.position = Vector3.MoveTowards (transform.position, target.transform.position, -moveSpeed);
			}
		}
	}
}