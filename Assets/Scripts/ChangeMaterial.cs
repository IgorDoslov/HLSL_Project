/*
Author:		        Igor Doslov
Date Created:       7/4/2021
Date Modified:      7/4/2021
File:		        ChangeMaterial.cs
Purpose:	        Changes the material of an object. Used in game to make colours appear on objects for a puzzle
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    Renderer mRend;
    public Material myMat;
    public bool materialHasChanged = false;
    // Start is called before the first frame update
    void Start()
    {
        mRend = GetComponent<Renderer>();
    }

    public void ChangeMat()
    {
        materialHasChanged = true;
        mRend.material = myMat;
    }
}
