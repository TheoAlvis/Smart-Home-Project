using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steam : MonoBehaviour
{
    public ParticleSystem steam;
    
    

    // Start is called before the first frame update
    void Start()
    {
        steam.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("5")) {
            steam.Play();
        }
        if (Input.GetKey("6")) {
            steam.Stop();
        }
    }
}


