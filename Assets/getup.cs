using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("q")) {
            transform.localScale += new Vector3(0, 0.02f, 0);
        }
        
    }
}
