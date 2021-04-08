/*
Author:		        Igor Doslov
Date Created:       7/4/2021
Date Modified:      7/4/2021
File:		        WinCondition.cs
Purpose:	        Attached to a trigger that when is touched by the player it will load the win scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public Button winButton;
    public SceneLoader sl;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Win");

            winButton.gameObject.SetActive(true);
            
            sl.LoadWinSceneName();

        }
    }
}
