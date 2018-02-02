using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
//we want to reference some components in the characters
using UnityEngine.UI;

public class AOpening : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject FadeScreenIn;
	public GameObject TextBox;

	// Use this for initialization
	void Start () {
		//stop the character in the beginning of the game
		ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
		StartCoroutine (ScenePlayer());

	}

	IEnumerator ScenePlayer (){
		//set at textbox that will say I need to get out of here
		yield return new WaitForSeconds (1.5f);
		FadeScreenIn.SetActive (false);
		TextBox.GetComponent<Text>().text = "I need to get ouf of here";
		yield return new WaitForSeconds (2);
		TextBox.GetComponent<Text> ().text = "";
		ThePlayer.GetComponent<FirstPersonController> ().enabled = true;


	}

}
