/*
Author:		Igor Doslov
Date:       7/4/2021
File:		GraphicsProjectApp.h
Purpose:	
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponentInParent<Animator>().gameObject.SetActive(false);

    }
}
