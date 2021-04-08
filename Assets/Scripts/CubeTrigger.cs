/*
Author:		        Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		        CubeTrigger.cs
Purpose:	        Makes the cubes dissolve, the bridge undissolve and the second GUI appear
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
   
    public Transform parent;
    public GameObject objectToAppear;
    public GameObject guiToAppear;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.transform.SetParent(parent);
            gameObject.GetComponent<DissolveControl>().shouldDissolve = true;
            other.gameObject.GetComponent<DissolveControl>().shouldDissolve = true;
            objectToAppear.SetActive(true);
            guiToAppear.SetActive(true);
            objectToAppear.GetComponent<DissolveControl>().ShouldUndissolveTrue();
            objectToAppear.GetComponent<DissolveControl>().ShouldDissolveFalse();

        }
    }
}
