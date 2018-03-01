using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
	// load the scene specified in nameOfScene

	public void changeScene(string nameOfScene){
		SceneManager.LoadScene (nameOfScene);
	}
}
