using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public int score;
    public Meatball meatball;
    public ParticleSystem splatter;

    // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    private Meatball meatballInPlay;
    public int howMuchToScore;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    void Update () {
        meatballInPlay = FindObjectOfType<Meatball>();
        if (meatballInPlay == null)
        {
            return;
        }
        howMuchToScore = meatballInPlay.scoreWorth;
	}

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Meatball")
        {
            score += howMuchToScore; // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
            Destroy(other.gameObject);
            Invoke("InstantiateMeatball", 2);
        }
    }

    private void InstantiateMeatball()
    {
        Instantiate(meatball);
    }
}
