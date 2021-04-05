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
        if (rb)
        {
            rb.MovePosition(Vector3.Lerp(rb.position, holder.position, Time.deltaTime * lerpSpeed));

            if (Input.GetMouseButtonDown(1))
            {
                rb.isKinematic = false;
                rb.AddForce(cam.transform.forward * throwForce, ForceMode.VelocityChange);
                rb = null;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (rb)
            {
                rb.isKinematic = false;
                rb = null;
            }
            else
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
