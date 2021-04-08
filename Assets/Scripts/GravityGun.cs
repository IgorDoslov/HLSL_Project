/*
Author:		        Igor Doslov
Date Created:       1/4/2021
Date Modified:      8/4/2021
File:		        GravityGun.cs
Purpose:	        Can pick up and throw objects that are set to layer 8
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGun : MonoBehaviour
{
    Camera cam;
    public float grabDistance = 10.0f;
    public float throwForce = 5.0f;
    public float lerpSpeed = 10.0f;
    public Transform holder;

    Rigidbody rb;
    int layerMask = 1 << 8;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // if there's a rigidbody picked up
        if (rb)
        {
            // Move the object to the holder and lerp its motion to make it smooth
            rb.MovePosition(Vector3.Lerp(rb.position, holder.position, Time.deltaTime * lerpSpeed));

            // Throw the object
            if (Input.GetMouseButtonDown(1))
            {
                rb.isKinematic = false;
                rb.AddForce(cam.transform.forward * throwForce, ForceMode.VelocityChange);
                rb = null;
            }
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            // Drop the object if holding one
            if (rb)
            {
                rb.isKinematic = false;
                rb = null;
            }
            else // Pick up an object if not holding one
            {
                Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));

                RaycastHit hit;

                if (Physics.Raycast(rayOrigin, cam.transform.forward, out hit, grabDistance, layerMask))
                {
                    
                        rb = hit.collider.gameObject.GetComponent<Rigidbody>();
                        if (rb)
                        {
                            rb.isKinematic = true;
                        }
                    
                }
            }
        }
    }
}
