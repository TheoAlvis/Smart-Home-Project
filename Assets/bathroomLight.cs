using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathroomLight : MonoBehaviour
{

	Light light;

	// Use this for initialization
	void Start() {
		light = GetComponent<Light>();
		light.enabled = !light.enabled;
	}

	// Update is called once per frame
	void Update() {
		// Toggle light on/off when L key is pressed.
		if (Input.GetKey("2")) {
			light.enabled = !light.enabled;
		}
	}
}
