/*
Author:		        Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		        ThirdPersonCamController.cs
Purpose:	        Controls the movement of the third person camera attached to the player
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamController : MonoBehaviour
{
    public float lookSensitivity = 2.0f;
    public float minXLook;
    public float maxXLook;
    public Transform camAnchor;
    public bool invertXRotation; // For inverting the controls
    private float curXRot;

    

    private void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    private void LateUpdate()
    {
        CamControl();
        
    }

    void CamControl()
    {
        if (PauseMenu.gameIsPaused == true) // Can't move if game is paused
            return;

        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        transform.eulerAngles += Vector3.up * x * lookSensitivity;

        // Inverts the controls
        if (invertXRotation)
            curXRot += y * lookSensitivity;
        else
            curXRot -= y * lookSensitivity;

        curXRot = Mathf.Clamp(curXRot, minXLook, maxXLook); // Stops player from being able to look to far up and down

        Vector3 clampedAngle = camAnchor.eulerAngles;
        clampedAngle.x = curXRot;

        camAnchor.eulerAngles = clampedAngle;

    }

    
}
