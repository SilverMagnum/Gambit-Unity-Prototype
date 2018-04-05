using UnityEngine;

public class GambitMenu: MonoBehaviour {
	public int hudMenuIndex;
	public int pauseMenuIndex;
	
	public void Update() {
		if(Input.GetButtonDown("Pause")) {
			Time.timeScale = 1f;
			gameObject.GetComponentInParent<LiteMenuManager>().OpenMenu(
				hudMenuIndex,
				true
			);
		}
	}
	
	public void OnBackPressed() {
		gameObject.GetComponentInParent<LiteMenuManager>().OpenMenu(
			pauseMenuIndex,
			true
		);
	}
}
