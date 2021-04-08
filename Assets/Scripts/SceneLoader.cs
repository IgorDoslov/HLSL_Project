/*
Author:		        Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		        SceneLoader.cs
Purpose:	        Loads the correct scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string menuSceneName;
    public string platformPuzzleSceneName;
    public string winSceneName;


    public void LoadMainMenu()
    {
        PauseMenu.gameIsPaused = false;
        Time.timeScale = 1f;

        SceneManager.LoadScene(menuSceneName);
    }

    public void LoadPlatformPuzzleSceneName()
    {
        Cursor.lockState = CursorLockMode.Locked;
        

        PauseMenu.gameIsPaused = false;
        
        Time.timeScale = 1f;

        SceneManager.LoadScene(platformPuzzleSceneName);

    }

    public void LoadWinSceneName()
    {
        Cursor.lockState = CursorLockMode.None;

        SceneManager.LoadScene(winSceneName);

    }
}
