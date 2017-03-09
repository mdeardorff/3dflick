using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.ootii.Cameras;
using com.ootii.Input;

public class gameController : MonoBehaviour {

	public GameObject[] allPieces;
	public GameObject currentObject;
	public GameObject indicatorArrow;
	public shotIndicatorScript indicatorScript;
	public Rigidbody rb;
	public int currentIndex;
	public float transitionDuration;
	public CameraController camController;
	public float shotStrength = 400.0f;
	public GameObject pauseMenuPrefab;
	private Canvas pauseMenuCanvas;
	private pieceController currentScript;
	public int currentTeam;




	// Use this for initialization
	void Start () {
		GameObject pauseMenu = Instantiate (pauseMenuPrefab);
		pauseMenuCanvas = pauseMenu.GetComponent<Canvas> ();
		pauseMenuCanvas.gameObject.SetActive(false);
		indicatorArrow = GameObject.FindGameObjectWithTag ("arrow");
		allPieces = GameObject.FindGameObjectsWithTag ("team2");
		Debug.Log (allPieces.Length);
		if (allPieces != null) {
		}
		else {
			Debug.Log ("no pieces found");
		}
		currentScript = currentObject.GetComponent<pieceController>();

	}
	
	// Update is called once per frame
	void Update () {
		checkPaused ();
		if (currentScript != currentObject.GetComponent<pieceController> ()) {
			currentScript = currentObject.GetComponent<pieceController> ();
		}


		if (InputManager.IsJustPressed ("ChangeLeftCharacter")) {
			if (currentIndex - 1 >= 0) {
				currentObject = allPieces [--currentIndex];
				currentScript = currentObject.GetComponent<pieceController>();
				indicatorScript.anchor = currentObject.GetComponent<Rigidbody> ();
			} else {
				currentObject = allPieces [allPieces.Length - 1];
				currentIndex = allPieces.Length - 1;
				currentScript = currentObject.GetComponent<pieceController>();
				indicatorScript.anchor = currentObject.GetComponent<Rigidbody> ();
			}
		}
			
		if (InputManager.IsJustPressed ("ChangeRightCharacter")) {
			if (currentIndex + 1 < allPieces.Length) {
				currentObject = allPieces [++currentIndex];
				currentScript = currentObject.GetComponent<pieceController>();
				indicatorScript.anchor = currentObject.GetComponent<Rigidbody> ();
			} else {
				currentObject = allPieces [0];
				currentIndex = 0;
				currentScript = currentObject.GetComponent<pieceController>();
				indicatorScript.anchor = currentObject.GetComponent<Rigidbody> ();
			}

		}
		if (InputManager.IsJustPressed ("ChargeShot")) {
			StartCoroutine(currentScript.shoot ());
			
		}

		if (InputManager.IsJustPressed ("CameraPanButtons")) {
			Debug.Log ("Switching to pan mode");
		}
			

	

	}

	void checkPaused() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (pauseMenuCanvas.gameObject.activeInHierarchy == false) {
				pauseMenuCanvas.gameObject.SetActive (true);
				Time.timeScale = 0;
				AudioListener.volume = 0;
			} else {
				pauseMenuCanvas.gameObject.SetActive (false);
				Time.timeScale = 1;
				AudioListener.volume = 1;
			}
		}
	}
				
		
}
