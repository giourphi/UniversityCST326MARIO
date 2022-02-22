using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    // Start is called before the first frame update
    float movementSpeed =10f;
    private Rigidbody rb;

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

        rb.velocity = new Vector3(x * movementSpeed, rb.velocity.y, 0f);



        if (Input.GetKey(KeyCode.Space))
        {

            velocityofJump = jumpForce;
            
           rb.transform.Translate(new Vector3(0,velocityofJump,0)*Time.deltaTime);
        }
        

    }
}
