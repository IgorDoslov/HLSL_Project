/*
Author:		Igor Doslov
Date:       7/4/2021
File:		GraphicsProjectApp.h
Purpose:	
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimEffectControl : MonoBehaviour
{
    Renderer mRend;
    [Range(0, 8)] public float myValEnter = 0f;
    [Range(0, 8)] public float myValExit = 0f;
    public bool shouldFade = false;
    public float changeSpeed = 2.0f;
    int pulseNum = 0;
    public int pulseCount = 8;
    // Start is called before the first frame update
    void Start()
    {
        mRend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldFade)
        {
            if(myValExit <= 8.0f)
            myValExit += changeSpeed * Time.deltaTime;

            mRend.material.SetFloat("_RimPower", myValExit);
        }
        if(myValExit >= 8.0f)
        {
            myValExit = 0.0f;
            pulseNum++;
        }
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
