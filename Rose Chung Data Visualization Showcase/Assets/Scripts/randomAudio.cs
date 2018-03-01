using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomAudio : MonoBehaviour {
	// clicking changes the audioclip, the skybox, and monolith texture to a random one

	public AudioClip[] soundFiles;
	public GvrAudioSource soundSource;

	public Material[] skyboxes;

	public GameObject monolith;
	public Material[] monolithmaterials;

	public void changeAudio () {
		// when clicked, a random audio clip starts playing

		int index = Random.Range (0, soundFiles.Length);
		Debug.Log("now playing"+soundFiles [index]);
		soundSource.clip = soundFiles [index];
		soundSource.Play ();
	}

	public void changeSkybox () {
		int index = Random.Range (0, skyboxes.Length);
		Debug.Log("skybox:"+ skyboxes [index]);
		RenderSettings.skybox = skyboxes [index];
	}

	public void changeTexture (){
		int index = Random.Range (0, monolithmaterials.Length);
		Debug.Log ("skybox:" + monolithmaterials [index]);
		monolith.GetComponent<MeshRenderer>().material= monolithmaterials [index];
	}
	
}
