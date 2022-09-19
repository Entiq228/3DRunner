using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    public float runSpeed;
    public float speedStrafe;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, runSpeed);

        if (Input.GetKey("d"))
        {
            rb.AddForce(speedStrafe * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speedStrafe * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
