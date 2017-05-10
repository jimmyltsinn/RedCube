using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; 

public class Spin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float speed = 90; 
	bool rotate = true; 

	public void buttonPressed(Button myObject) {
		rotate = !rotate; 
		for (int i = 0; i < myObject.transform.childCount; ++i) {
			Debug.Log (myObject.transform.GetChild (i).name);
			if (myObject.transform.GetChild(i).transform.name == "Text") {
				myObject.transform.GetChild (i).transform.GetComponent<Text>().text = rotate ? "ON" : "OFF"; 
			}
		}
	}

	public void updateSpeed(float val) {
		speed = val * 90; 
	}

	// Update is called once per frame
	void Update () {
		if (rotate)
			transform.Rotate(Vector3.up * Time.deltaTime * speed);
	}
}
