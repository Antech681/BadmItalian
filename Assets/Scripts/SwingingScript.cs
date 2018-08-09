using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingScript : MonoBehaviour {
    
    public RacquetControl racCon;
    private Rigidbody rb;

    public float hitForce;

    public float velocityX;
    public float velocityY;

    private SFXManager sfxMan;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        velocityY = rb.velocity.y;
        sfxMan = FindObjectOfType<SFXManager>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(racCon.hitLeft))
        {
            //rb.AddForce(new Vector3(-hitForce, 0, 0), ForceMode.VelocityChange);
            rb.velocity = new Vector3(-hitForce, 0);
            sfxMan.racquetSwing.Play();
        }
        if (Input.GetKeyDown(racCon.hitRight))
        {
            //rb.AddForce(new Vector3(hitForce, 0, 0), ForceMode.VelocityChange);
            rb.velocity = new Vector3(hitForce, 0);
            sfxMan.racquetSwing.Play();
        }
    }
}
