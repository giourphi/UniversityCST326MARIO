using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Score UI")] 
    public GameObject scoreText;
    public GameObject timeCounter;

    [Header("Blocks")] 
    public GameObject brick;
    public GameObject Question;

    public  float totaltime = 400f;

    private Rigidbody rb; 
    // Update is called once per frame
    void Update()
    {
        totaltime -= Time.deltaTime;
        UpdateLeveltimer(totaltime);
        
     
    }

    private void Reset()
    {
        
        
    }

    public void UpdateLeveltimer(float totalseconds)
    {
        //int seconds = Mathf.RoundToInt(totalseconds % 60f);

        string formatedSeconds = totalseconds.ToString();


        timeCounter.GetComponent<TextMeshProUGUI>().text = formatedSeconds;

        if (totalseconds == 0)
        {
            Reset();
        }

    }

    public void UpdateScore()
    {
       // if (rb.GetComponent<RaycastDestroyblocks>())
        {
            if (brick.gameObject)
            {
                int x = 100;
                scoreText.GetComponent<TextMeshProUGUI>().text = x.ToString()+scoreText.GetComponent<TextMeshProUGUI>().text;
            }

            if (rb.GetComponent<LevelParser>().brickPrefab)
            {
                int y = 10;
                scoreText.GetComponent<TextMeshProUGUI>().text =
                    y.ToString() + scoreText.GetComponent<TextMeshProUGUI>().text;
            }
            
        }
    }
}


