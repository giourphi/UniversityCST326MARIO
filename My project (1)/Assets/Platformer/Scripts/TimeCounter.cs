using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Packages.Rider.Editor.UnitTesting;
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
    public GameObject countDown;
    
    [Header("Blocks")] 
    public GameObject brick;
    public GameObject Question;

    public  float totalTime = 400f;
    public float timeLimit = 100f;
    public float scoreStart = 0f;
    private Vector3 originalPosofBrick;
    private Vector3 originalPosofQuestion;
    
    private Rigidbody rb; 
    // Update is called once per frame


    void Start()
    {
        originalPosofBrick = new Vector3(brick.transform.position.x, brick.transform.position.y,
            brick.transform.position.z);

        originalPosofQuestion = new Vector3(Question.transform.position.x, Question.transform.position.y,
            Question.transform.position.z);
    }

    void Update()
    {
        totalTime -= Time.deltaTime;
        timeLimit -= Time.deltaTime;
        if (timeLimit > 0)
        {
            UpdateLeveltimer(totalTime, timeLimit);
        }
        else
        {
            Debug.Log("Player failed to complete the level ");
            Reset();
        }
        //   scoreText.GetComponent<TextMeshProUGUI>().text = scorestart.ToString();

    }

    public void Reset()
    {
        totalTime = 400f;
        timeLimit = 100f;

        float blankTime = 00000f;
        scoreStart = 0f;
        scoreText.GetComponent<TextMeshProUGUI>().text = blankTime.ToString();

        brick.transform.position = originalPosofBrick;
        Question.transform.position = originalPosofQuestion;
    }

    public void UpdateLeveltimer(float totalseconds,float timeLeft)
    {
        //int seconds = Mathf.RoundToInt(totalseconds % 60f);

        string formatedSeconds = totalseconds.ToString();

        string timeLeftseconds = timeLeft.ToString();

        timeCounter.GetComponent<TextMeshProUGUI>().text = formatedSeconds;
        countDown.GetComponent<TextMeshProUGUI>().text = timeLeftseconds;
        
        if (totalseconds == 0)
        {
            Reset();
        }

    }

    public void UpdateScoreBrick()
    { 
        int x = 100;
        scoreStart += x;
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score " + scoreStart.ToString();

    }

    public void UpdateScoreQuestion()
    {
        int y = 100;
        scoreStart += y;
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score " + scoreStart.ToString();
    }
    
}


