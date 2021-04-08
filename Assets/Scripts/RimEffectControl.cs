/*
Author:		        Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		        RimEffectControl.cs
Purpose:	        Creates a pulse effect using the rimlight shader for the hit effect of the ball
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimEffectControl : MonoBehaviour
{
    Renderer mRend;
    [Range(0, 8)] public float myValEnter = 0f; // When ball hits
    [Range(0, 8)] public float myValExit = 0f; // After ball hits
    public bool shouldFade = false;
    public float changeSpeed = 2.0f; // effect speed
    int pulseNum = 0;
    public int pulseCount = 8; // How many times to pulse

    // Start is called before the first frame update
    void Start()
    {
        mRend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldFade) // Fade the rimlight effect
        {
            if(myValExit <= 8.0f)
            myValExit += changeSpeed * Time.deltaTime;

            mRend.material.SetFloat("_RimPower", myValExit);
        }
        if(myValExit >= 8.0f) // Reset the rimlight to start the next pulse
        {
            myValExit = 0.0f;
            pulseNum++;
        }
        // Pulse for chosen number
        if (pulseNum == pulseCount)
            shouldFade = false;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        mRend.material.SetFloat("_RimPower", myValEnter);

    }

    private void OnCollisionExit(Collision collision)
    {
        shouldFade = true;
    }
}
