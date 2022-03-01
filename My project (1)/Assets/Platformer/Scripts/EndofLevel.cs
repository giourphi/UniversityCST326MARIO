using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndofLevel : MonoBehaviour
{
    
    
    [Header("Boundaries")] 
    public GameObject endofLevel;
    public GameObject fellOfMap;
    
    
    public Rigidbody rb;

    public float playerLives = 3f;
    // Start is called before the first frame update

    public Vector3 startpos;
    
    
    
    
    private void Awake()
    {
        startpos = this.transform.position;
    }

    

    void RespawnPlayer()
    {
        playerLives--;
        this.transform.position = startpos;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Player finished the level ");
            
        }

        if (collision.gameObject.CompareTag("Respawn"))
        {
            Debug.Log("player died..Respawning");

            if (playerLives > 0)
            {
                RespawnPlayer();
                rb.gameObject.GetComponent<TimeCounter>().Reset();
                
            }
            else
            {
                
                Debug.Log("GAME OVER");
            }
        }
    }
}
