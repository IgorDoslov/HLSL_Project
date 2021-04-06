using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    Renderer mRend;
    public Material myMat;
    // Start is called before the first frame update
    void Start()
    {
        mRend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMat()
    {
        mRend.material = myMat;
    }
}
