using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Controller : MonoBehaviour
{
    public Rigidbody rigidBody;


    private bool leftTurn = false;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("THRUSTERS ENGAGED");
            rigidBody.AddRelativeForce(Vector3.up);
        }


        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            print("!!!Conflicting Rotation!!!");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            print("Rotating Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotating Right");
        } 
    }
}
