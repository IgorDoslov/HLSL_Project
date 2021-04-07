/*
Author:		Igor Doslov
Date:       7/4/2021
File:		GraphicsProjectApp.h
Purpose:	
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
