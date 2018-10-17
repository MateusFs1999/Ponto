﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] moveSpot;
    public int randomSPot;





	// Use this for initialization
	void Start () {
        waitTime = startWaitTime;
        randomSPot = Random.Range(0, moveSpot.Length);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot[randomSPot].position, speed*Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSpot[randomSPot].position)<0.2f)
        {
            if (waitTime<=0)
            {
                randomSPot = Random.Range(0, moveSpot.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        
        }
		
	}
}
