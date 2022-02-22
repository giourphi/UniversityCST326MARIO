using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RaycastDestroyblocks : MonoBehaviour

{

    [Header("Blocks")] 
    public GameObject brick;
    public GameObject Question;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            brick = GameObject.FindWithTag("Brick");
            Question = GameObject.FindWithTag("Question");
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject != null)
            {
            
        
                
                Destroy(Question);
                gameObject.GetComponent<TimeCounter>().UpdateScoreQuestion();

            }
            else
            {
                
                Destroy(brick);
                gameObject.GetComponent<TimeCounter>().UpdateScoreBrick();
            }
            

        }
    }
}
