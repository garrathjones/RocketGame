using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainTrust = 1000f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainTrust * Time.deltaTime);
        }
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("right");
        }
    }


}
