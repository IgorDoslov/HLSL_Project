/*
Author:		        Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		        CubeTrigger.cs
Purpose:	
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
   
    public Transform parent;
    public GameObject objectToAppear;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.transform.SetParent(parent);
            gameObject.GetComponent<DissolveControl>().shouldDissolve = true;
            other.gameObject.GetComponent<DissolveControl>().shouldDissolve = true;
            objectToAppear.SetActive(true);
            objectToAppear.GetComponent<DissolveControl>().ShouldUndissolveTrue();
            objectToAppear.GetComponent<DissolveControl>().ShouldDissolveFalse();

        }
    }
}
