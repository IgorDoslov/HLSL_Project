/*
Author:		Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		DissolveControl.cs
Purpose:	Controls the dissolving and undissolving of an object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveControl : MonoBehaviour
{
    MeshRenderer mRend;
    public bool shouldDissolve;
    public bool shouldUndissolve;
    [Range(0, 1)] public float myVal = 0f;
    public float dissolveTime;
    public float setInactiveTime = 2.6f;


    // Start is called before the first frame update
    void Start()
    {
        mRend = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldDissolve)
        {
            StartDissolve();
        }

        if (shouldUndissolve)
        {
            Undissolve();
        }
    }

    public void StartDissolve()
    {
        myVal += dissolveTime * Time.deltaTime;
        mRend.material.SetFloat("_Amount", myVal);
        Invoke("SetInactive", setInactiveTime);
        if (myVal > 1.0f)
            myVal = 1.0f;
    }

    public void Undissolve()
    {
        if (myVal > 0)
        {
            myVal -= dissolveTime * Time.deltaTime;
        }
        mRend.material.SetFloat("_Amount", myVal);
        //Invoke("SetAactive", setInactiveTime);
        if (myVal < 0.0f)
            myVal = 0.0f;
    }
    // These are for control from in game GUI buttons
    public void SetInactive()
    {
        gameObject.SetActive(false);
    }

    public void SetActive()
    {
        gameObject.SetActive(true);
    }

    public void ShouldDissolve()
    {
        shouldDissolve = true;
    }

    public void ShouldDissolveFalse()
    {
        shouldDissolve = false;
    }

    public void ShouldUndissolveTrue()
    {
        shouldUndissolve = true;
    }

    public void ShouldUndissolveFalse()
    {
        shouldUndissolve = false;
    }

}