using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UnityEngine.UI - so that the game recognizes that we are using UI elements

public class PickUpPistol : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakePistol;
	public GameObject RealPistol;
	public GameObject GuideArrow;
	public GameObject ExtraCross;


	// Update is called once per frame
	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;

	}

	void OnMouseOver(){
	
		if (TheDistance <= 2) {
			ExtraCross.SetActive (true);
			ActionText.GetComponent<Text> ().text = "Pick Up Pistol";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);


		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 2) {
				ExtraCross.SetActive (false);
				//if we are less than 3 or NEAR on the door we need to disable the box collider of the door
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				FakePistol.SetActive (false);
				RealPistol.SetActive (true);
				ExtraCross.SetActive (false);
				GuideArrow.SetActive (false);
			}
		
		}
	}

	//When We are not looking on the door we need to turn off the ActionDisplay and ActionText
	void OnMouseExit(){
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

}
