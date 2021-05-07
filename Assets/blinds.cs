using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinds : MonoBehaviour { 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1")) {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
    }
}
