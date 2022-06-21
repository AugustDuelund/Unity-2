using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    //Fetches text input field from canvas on LavaLevel
    public Text timerText;

    //Starts the timer
    private float startTime = Time.time;
    private bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    //Keeps running the timer when Boolean is false. When you finish game changes boolean to true and stops timer.
    void Update()
    {
        if (finished) 
        {
            return;
        }
        else
        {
            float t = Time.time - startTime;

            //Changes to number to string so it can be displayed in text field.
            string minutes = ((int) t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }
    }

    //when finishing game and running WinBox.cs this is called to change boolean to true.
    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;
    }
}