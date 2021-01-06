using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Controller : MonoBehaviour
{
    private bool leftTurn = false;
    void Start()
    {
        
    }

    void Update()
    {
        PlayerInput();
    }

    private static void PlayerInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("THRUSTERS ENGAGED");
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
