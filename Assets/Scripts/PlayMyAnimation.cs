/*
Author:		        Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		        PlayMyAnimation.cs
Purpose:	        Makes animation play for the platforms and triggers dissolving for objects in colour puzzle
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