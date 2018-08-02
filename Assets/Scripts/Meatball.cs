using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meatball : MonoBehaviour {

    public bool serving;

    private Rigidbody rb;
    public float impactForce;
    public Vector3 vel;
    public float velocityX;
    public float velocityY;
    public float addedForce;

    public int scoreWorth;

    public Vector3 startingPosition;
    float[] serveHorizontal = new float[2] { -10, 10 };
    public float serveStrength;

    public float timer;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
        serving = true;
        addedForce = 4.5f;
	}
	
	// Update is called once per frame
	void Update () {
        if (serving == true)
        {
            rb.useGravity = false;
            rb.isKinematic = true;
            transform.position = startingPosition;

            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                LaunchBall();
            }
        }

        vel = rb.velocity;
        //rb.velocity = vel;

        velocityX = rb.velocity.x;
        addedForce += 0.001f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(velocityX, impactForce, 0);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            rb.velocity = new Vector3(velocityX + addedForce, impactForce, 0);
        }
        if (collision.gameObject.tag == "Player2")
        {
            rb.velocity = new Vector3(velocityX - addedForce, impactForce, 0);
        }
        if (collision.gameObject.tag == "Respawn")
        {
            rb.velocity = Vector3.zero;
            rb.useGravity = false;
            rb.isKinematic = true;
            Invoke("LaunchBall", 2);
        }
    }

    public void LaunchBall()
    {
        transform.position = startingPosition;
        serving = false;
        rb.useGravity = true;
        rb.isKinematic = false;
        rb.velocity = Vector3.zero;
        rb.velocity = new Vector3(serveHorizontal[Random.Range(0, 2)], serveStrength, 0);
    }
}
