using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RaycastDestroyblocks : MonoBehaviour

{

    [Header("Blocks")] 
    public GameObject brick;
    public GameObject Question ;
    // Start is called before the first frame update
  
    public Rigidbody rb;
   
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            gameObject.GetComponent<TimeCounter>().UpdateScoreBrick();
           
        }
        
        if(collision.gameObject.CompareTag("Question"))
        {
            Destroy(collision.gameObject);
            gameObject.GetComponent<TimeCounter>().UpdateScoreQuestion();
            
        }
    }

}
