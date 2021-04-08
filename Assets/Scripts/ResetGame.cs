/*
Author:		        Igor Doslov
Date Created:       8/4/2021
Date Modified:      8/4/2021
File:		        ResetGame.cs
Purpose:	        Reloads the scene if you fall off the edge or drop a cube off the edge
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("PlatformLevel");
    }
}
