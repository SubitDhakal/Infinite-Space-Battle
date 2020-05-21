using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    float timeStart=0f;
    Text timeBox;
    int minutes, seconds;
    string timerString;
    


    // Start is called before the first frame update
    void Start()
    {
        timeBox = GetComponent<Text>();
        //timeBox.text = timeStart.ToString("F2");

    }

    // Update is called once per frame
    void Update()
    {
       timeStart += Time.deltaTime;
       seconds = (int)(timeStart % 60);
       minutes = (int)(timeStart / 60) % 60;
       //hours = (int)(timeStart / 3600) % 24;
        timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
       timeBox.text = timerString;
    }
}
