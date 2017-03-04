using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public Canvas MainCanvas;
	public Canvas OptionsCanvas;
	public Button SoundButton;

	void Awake()
	{
		OptionsCanvas.enabled = false;
		SoundButton.GetComponent<Image> ().color = Color.green;
	}

	public void OptionsOn()
	{
		OptionsCanvas.enabled = true;
		MainCanvas.enabled = false;
	}

	public void ReturnToMain()
	{
		OptionsCanvas.enabled = false;
		MainCanvas.enabled = true;
	}

	public void LoadIntoGame()
	{
		SceneManager.LoadScene (1);
	}

	public void SoundToggle()
	{
		if (AudioListener.volume == 0) {
			SoundButton.GetComponent<Image> ().color = Color.green;
			AudioListener.volume = 1;
		} else {
			SoundButton.GetComponent<Image> ().color = Color.red;
			AudioListener.volume = 0;
		}
	}
}
