using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timerTest : MonoBehaviour
{

    //aimed time in seconds (240) multiplied by 60 due to frames per second
    private int timeGoal = 14400;
    private int convTime = 0;
    public SceneSwitch timerEnd;
    public TextMeshProUGUI timeDisp;
    // Start is called before the first frame update
    void Start()
    {
        totalScore.fullScore = 0;
        QualitySettings.vSyncCount = 0;  // this disables vsync so I can set the frame rate to limit the timer
        Application.targetFrameRate = 60; // hoepfully limit the frame rate
    }

    // Update is called once per frame
    void Update()
    {
        timeGoal--;
        if(timeGoal <= 0)
        {
            timerEnd.SwitchScene();
        }
        convTime = timeGoal / 60;
        timeDisp.text = convTime.ToString();
    }
}
