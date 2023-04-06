using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] float startTimer;
    [SerializeField]float counter;
    [SerializeField] Text CountDownTimeNumber;
    [SerializeField] int timeRemaining;
    public bool timeBeZero;

    void Start()
    {
        counter = startTimer;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTime();
        if (counter >= 0)
        {
            counter -= Time.deltaTime;
        }else 
        {
            timeBeZero = true;
            SceneManager.LoadScene("JumpScare");
        }
    }
    public void DisplayTime()
    {
        timeRemaining = Mathf.RoundToInt(counter);
        CountDownTimeNumber.text = string.Format("{0}:{1:00}", timeRemaining / 60 , timeRemaining % 60);
    }
}
