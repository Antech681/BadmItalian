using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meatball : MonoBehaviour {

    private Rigidbody rb;
    public float impactForce;
    public Vector3 vel;
    public float velocityX;
    public float velocityY;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        vel = rb.velocity;
        //rb.velocity = vel;

        velocityX = rb.velocity.x;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(velocityX, impactForce, 0);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.velocity = new Vector3(velocityX, impactForce, 0);
        }
    }
}
