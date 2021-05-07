using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cha : MonoBehaviour {
    public ParticleSystem water;



    // Start is called before the first frame update
    void Start() {
        water.Stop();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("2")) {
            water.Play();
        }
        if (Input.GetKey("3")) {
            water.Stop();
        }
    }
}
