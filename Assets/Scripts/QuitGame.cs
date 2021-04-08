/*
Author:		        Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		        QuitGame.cs
Purpose:	        Allows player to quit from button in menu or by pressing escape
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            QuitTheGame();
        }
    }

    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
