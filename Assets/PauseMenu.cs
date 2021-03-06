﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;

    public GameObject pausemenuUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    void Pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
}