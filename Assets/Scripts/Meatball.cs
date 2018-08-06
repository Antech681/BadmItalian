using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meatball : MonoBehaviour {

    public GameplayManager gameManager;

    public bool serving;

    private Rigidbody rb;
    public float impactForce;
    public Vector3 vel;
    public float velocityX;
    public float velocityY;
    public float addedForce;

    public int meatball; // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    public int scoreWorth;

    public Vector3 startingPosition;
    float[] serveHorizontal = new float[2] { -10, 10 };
    public float serveStrength;

    public float timer;

    public ParticleSystem splatter;

    // Use this for initialization
    void Awake () {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameplayManager>();
        if (gameManager.gameOn)
        {
            serving = true;
            addedForce = 4.5f;
            gameManager.InstTimer();
            ChooseBall(); // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (gameManager.gameOn)
        {
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

            //vel = rb.velocity;

            velocityX = rb.velocity.x;
            addedForce += 0.001f;

            if (scoreWorth == 1)
            {
                //Sprite 1
            }
            else if (scoreWorth == 2)
            {
                //Sprite 2
            }
            else if (scoreWorth == 3)
            {
                //Sprite 3
            }
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            Instantiate(splatter, other.gameObject.transform);
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

    // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    public void ChooseBall()
    {
        meatball = Random.Range(1, 10);
        if (meatball < 6)
        {
            scoreWorth = 1;
            Debug.Log("ONE");
        }
        else if (meatball > 5 && meatball < 9)
        {
            scoreWorth = 2;
            Debug.Log("TWO");
        }
        else if (meatball > 8)
        {
            scoreWorth = 3;
            Debug.Log("THREE");
        }
    }
}
