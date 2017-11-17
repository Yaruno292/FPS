using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeIsTicking : MonoBehaviour {

    public static int Time;

    int TickTime = 10;

    int SurviveTime = 2000;

	// Use this for initialization
	void Start () {
        Time = SurviveTime;
	}
	
	// Update is called once per frame
	void Update () {

        TickTime -= 1;
        if(TickTime <= 0)
        {
            TickTime = 10;
            Time -= 1;
        }

        if(Time <= 0)
        {
            Time = SurviveTime;
            SceneManager.LoadScene("WinScreen");
        }
	}
}
