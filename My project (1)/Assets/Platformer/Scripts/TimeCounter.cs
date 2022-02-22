using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
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

    public float scorestart = 0f;
    
    private Rigidbody rb; 
    // Update is called once per frame
    void Update()
    {
        totaltime -= Time.deltaTime;
        UpdateLeveltimer(totaltime);
     //   scoreText.GetComponent<TextMeshProUGUI>().text = scorestart.ToString();

    }

    private void Reset()
    {
        totaltime = 400f;
        scoreText.GetComponent<TextMeshProUGUI>().text = scorestart.ToString();
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

    public void UpdateScoreBrick()
    { 
        int x = 100;
        scorestart += x;
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score " + scorestart.ToString();

    }

    public void UpdateScoreQuestion()
    {
        int y = 10;
        scorestart += y;
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score " + scorestart.ToString();
    }
    
}


