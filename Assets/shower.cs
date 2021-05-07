using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shower : MonoBehaviour
{
    public ParticleSystem water;



    // Start is called before the first frame update
    void Start() {
        water.Stop();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("4")) {
            water.Play();
        }
        if (Input.GetKey("5")) {
            water.Stop();
        }
    }
}
