using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPhone : MonoBehaviour {

	public GameObject screenCamera;
	public GameObject smartphoneScanner;
	public GameObject smartphoneBench;

	bool pickedUp = false;

	public void pickUpPhone(){
		if (!pickedUp) {
			screenCamera.SetActive (true);
			smartphoneScanner.SetActive (true);
			smartphoneBench.SetActive (false);
			pickedUp = true;
		} else {
			screenCamera.SetActive (false);
			smartphoneScanner.SetActive (false);
			smartphoneBench.SetActive (true);
			pickedUp = false;
		}
	}
}
