/*
Author:		        Igor Doslov
Date Created:       8/4/2021
Date Modified:      8/4/2021
File:		        WallAndBallCanFall.cs
Purpose:	        To make the ball and wall not kinematic so that 
                    the ball hits the wall and it falls over to create a bridge
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAndBallCanFall : MonoBehaviour
{
    public Rigidbody ball;
    Rigidbody wall;

    // Start is called before the first frame update
    void Start()
    {
        wall = GetComponent<Rigidbody>();
    }

    public void CanFall()
    {
        ball.isKinematic = false;
        wall.isKinematic = false;
    }
}
