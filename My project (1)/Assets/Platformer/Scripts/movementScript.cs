using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    // Start is called before the first frame update
    float movementSpeed =10f;
    private Rigidbody rb;
    private float sprintSpeed = 20f;

    public float jumpForce = 10f;
    private float velocityofJump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");

        
        
        if (Input.GetKey(KeyCode.Space))
        {

            velocityofJump = jumpForce;
            
           rb.transform.Translate(new Vector3(0,velocityofJump,0)*Time.deltaTime);

           Mathf.Clamp(0, velocityofJump, 5);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {

            rb.velocity = new Vector3(x * sprintSpeed, rb.velocity.y, 0f);
        }
        else
        {
            rb.velocity = new Vector3(x * movementSpeed, rb.velocity.y, 0f);
        }

    }
}
