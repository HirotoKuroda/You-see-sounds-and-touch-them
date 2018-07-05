using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlscene4 : MonoBehaviour {

	private bool counter; //カウンタ
	private float time; //経過時間

	// Use this for initialization
	void Start () {
		counter = false;
		time = 0;
	}

	// Update is called once per frame
	void Update () {
		if (counter) {
			time += Time.deltaTime;

			if (time >= 4) {
				SceneManager.LoadScene ("3");
			}
		}
	}

	public void enterPointer(){
		Debug.Log ("Enter Pointer");
		counter = true;
	}

	public void exitPointer(){
		Debug.Log ("Exit Pointer");
		counter = false;
		time = 0;
	}

}

