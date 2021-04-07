/*
Author:		Igor Doslov
Date:       7/4/2021
File:		GraphicsProjectApp.h
Purpose:	
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyAnimation : MonoBehaviour
{
    public Animator anim;
    public string trigger;
    public string tagKeyword;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagKeyword))
        {

            anim.SetBool(trigger, true);
            gameObject.GetComponent<DissolveControl>().shouldDissolve = true;
            other.gameObject.GetComponent<DissolveControl>().shouldDissolve = true;
        }
    }
}