using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBackgroundSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ((RectTransform)transform).sizeDelta = new Vector2(Screen.height/3*4, Screen.height);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
