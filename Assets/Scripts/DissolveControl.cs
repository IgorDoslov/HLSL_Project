using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveControl : MonoBehaviour
{
    MeshRenderer mRend;
    public bool shouldDissolve;
    public bool shouldUndissolve;
    [Range(0, 1)] public float myVal = 0f;
    public float dissolveTime;
    // Start is called before the first frame update
    void Start()
    {
        mRend = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldDissolve)
        {
            StartDissolve();
        }
    }

    public void StartDissolve()
    {
        myVal += dissolveTime * Time.deltaTime;
        mRend.material.SetFloat("_Amount", myVal);
        Invoke("SetInactive", 2.6f);
    }

    public void Undissolve()
    {
        myVal -= dissolveTime * Time.deltaTime;
        mRend.material.SetFloat("_Amount", myVal);
        Invoke("SetAactive", 2.6f);
    }

    public void SetInactive()
    {
        gameObject.SetActive(false);
    }

    public void SetActive()
    {
        gameObject.SetActive(true);
    }
}