﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperArmMovement : MonoBehaviour {
    public KeyCode yRightRotationActivationKey = KeyCode.E;
    public KeyCode yLeftRotationActivationKey = KeyCode.Q;
    public KeyCode xUpRotationActivationKey = KeyCode.W;
    public KeyCode xDownRotationActivationKey = KeyCode.S;
    public float forceAmount = 10;
    Rigidbody body;
    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(yRightRotationActivationKey))
        {
            body.AddTorque((transform.up) * forceAmount, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(yLeftRotationActivationKey))
        {
            body.AddTorque((-transform.up) * forceAmount, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(xUpRotationActivationKey))
        {
            body.AddTorque((-transform.right) * forceAmount, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(xDownRotationActivationKey))
        {
            body.AddTorque((transform.right) * forceAmount, ForceMode.Impulse);
        }
        body.AddForce(new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f)), ForceMode.Impulse);
    }
}