using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour {

	private float time;

	// Use this for initialization
	void Start () {
		time = 0;
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time >= 30) {
			SceneManager.LoadScene ("0");
		}
	}
}
