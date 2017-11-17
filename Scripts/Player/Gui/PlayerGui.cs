using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGui : MonoBehaviour {

    private Text GuiText;

    private Text TimeText;

    // Use this for initialization
    void Start () {
		
	}

    private void Awake()
    {
        GuiText = GameObject.Find("GuiText").GetComponent<Text>();

        TimeText = GameObject.Find("TimeUI").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        GuiText.text = "Bullets: " + Ammo.bulletsRemaining;
        TimeText.text = "Time Left: " + TimeIsTicking.Time;
    }
}
