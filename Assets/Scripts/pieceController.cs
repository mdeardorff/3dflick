using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.ootii.Input;

public class pieceController : MonoBehaviour {
	private Rigidbody rb;
	private GameObject shotIndicator;
	public float shotChargeRate = 10f;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		shotIndicator = GameObject.FindGameObjectWithTag ("arrow");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator shoot() {
		float power = 1.0f;
		while (InputManager.IsPressed ("ChargeShot")) {
			power += shotChargeRate * Time.deltaTime;
			if (power > 30.0f)
				break;
			yield return 0;
		}

		rb.AddForce (shotIndicator.transform.forward * -power, ForceMode.Impulse);
		yield return 0;
	}
}
