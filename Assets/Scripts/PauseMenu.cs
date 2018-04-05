using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu: MonoBehaviour {
	public int hudMenuIndex;
	public int gambitMenuIndex;
	
	public void Update() {
		if(Input.GetButtonDown("Pause")) {
			Time.timeScale = 1f;
			gameObject.GetComponentInParent<LiteMenuManager>().OpenMenu(
				hudMenuIndex,
				true
			);
		}
	}
	
	public void OnResumePressed() {
		Time.timeScale = 1f;
		gameObject.GetComponentInParent<LiteMenuManager>().OpenMenu(
			hudMenuIndex,
			true
		);
	}

	public void OnGambitPressed() {
		gameObject.GetComponentInParent<LiteMenuManager>().OpenMenu(
			gambitMenuIndex,
			true
		);
	}
	
	public void OnQuitPressed()	{
		Debug.Log("Quit button pressed!! Program closes.");
		Application.Quit();
	}
}
