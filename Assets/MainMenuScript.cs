﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayTheGame()
    {
        SceneManager.LoadScene("CardTest");
    }

    public void QuitTheGame()
    {
        Debug.Log("QUIT the Game");
        Application.Quit();
    }
}
