using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCameraRotation : MonoBehaviour {
	// CURRENTLY DOESN'T WORK

	public Camera camera; // the main camera

	// Use this for initialization
	void Start () {
		float rotX = camera.transform.rotation.eulerAngles.x;
		float rotY = camera.transform.rotation.eulerAngles.y;

		Debug.Log (rotX+"\n"+rotY);

		//reset the camera rotation to 0 at the start
		camera.transform.rotation= Quaternion.Euler(rotX,rotY,0);
		
	}

}
