/*
Author:		Igor Doslov
Date:       7/4/2021
File:		GraphicsProjectApp.h
Purpose:	
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    Renderer mRend;
    public Material myMat;
    // Start is called before the first frame update
    void Start()
    {
        mRend = GetComponent<Renderer>();
    }

    public void ChangeMat()
    {
        mRend.material = myMat;
    }
}
