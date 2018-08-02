﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public int score;
    public Meatball meatball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Meatball")
        {
            score++;
            Destroy(other.gameObject);
            Invoke("InstantiateMeatball", 2);
        }
    }

    private void InstantiateMeatball()
    {
        Instantiate(meatball);
    }
}
