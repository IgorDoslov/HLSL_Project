﻿/*
Author:		Igor Doslov
Date:       7/4/2021
File:		GraphicsProjectApp.h
Purpose:	
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public Rigidbody ball;
    public Rigidbody wall;
    public Transform parent;
    //public GameObject triggerEffect;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.transform.SetParent(parent);
            //Instantiate(triggerEffect, transform.position, Quaternion.identity);
            gameObject.GetComponent<DissolveControl>().shouldDissolve = true;
            other.gameObject.GetComponent<DissolveControl>().shouldDissolve = true;
            ball.isKinematic = false;
            wall.isKinematic = false;
        }
    }
}
