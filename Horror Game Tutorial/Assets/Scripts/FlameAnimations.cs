using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour {

	public int LightMode;
	public GameObject flameLight;


	// Update is called once per frame
	void Update () {
	
		if (LightMode == 0) {
			StartCoroutine (AnimateLight ());

		}

	}

	IEnumerator AnimateLight() {

		LightMode = Random.Range (1, 4);
		if (LightMode == 1) {
		
			flameLight.GetComponent<Animation>().Play("TorchAnim1");
		}
		if (LightMode == 2) {

			flameLight.GetComponent<Animation>().Play("TorchAnim2");
		}
		if (LightMode == 3) {

			flameLight.GetComponent<Animation>().Play("TorchAnim3");
		}

		yield return new WaitForSeconds (0.99f);
			LightMode = 0;
	}
}
