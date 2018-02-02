using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class BfirstTrigger : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject TheMarker;

	void OnTriggerEnter() {
	
		ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
		StartCoroutine (ScenePlayer ());
	
	}

	IEnumerator ScenePlayer() {
	
		TextBox.GetComponent<Text>().text = "There's a weapon on the table";
		yield return new WaitForSeconds (1.5f);
		TextBox.GetComponent<Text>().text = "";
		ThePlayer.GetComponent<FirstPersonController> ().enabled = true;
		TheMarker.SetActive (true);
	}
}
