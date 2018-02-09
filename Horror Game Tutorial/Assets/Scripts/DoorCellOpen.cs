using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UnityEngine.UI - so that the game recognizes that we are using UI elements

public class DoorCellOpen : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject TheDoor;
	public AudioSource CreakSound;
	public GameObject ExtraCross;


	// Update is called once per frame
	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;

	}

	void OnMouseOver(){
	
		if (TheDistance <= 2) {
			ExtraCross.SetActive (true);
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
				TheDoor.GetComponent<Animation> ().Play ("DoorOpenAnim");
				CreakSound.Play ();

			}
		
		}
	}

	//When We are not looking on the door we need to turn off the ActionDisplay and ActionText
	void OnMouseExit(){
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

}
