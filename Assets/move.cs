using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public CharacterController controller;

    public float speed = 4f;


    // Use this for initialization
    void Start() {

   
    }

    // Update is called once per frame
    void Update() {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;


        controller.Move(move * speed * Time.deltaTime);

    }

}