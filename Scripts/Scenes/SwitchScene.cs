﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

    public void Retry(string sceneName)
    {
        SceneManager.LoadScene("FPS");
    }

    public void MainMenu(string sceneName)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
