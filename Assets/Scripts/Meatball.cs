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
    public float serveStrength;

    public float timer;

    public ParticleSystem splatter;

    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    private SFXManager sfxMan;
    private ParticleSystem partSys;
    private ParticleSystem.EmissionModule emisMod;

    private LadleServe ladle;

    // Use this for initialization
    void Awake () {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameplayManager>();
        sfxMan = FindObjectOfType<SFXManager>();
        partSys = GetComponentInChildren<ParticleSystem>();
        emisMod = partSys.emission;
        ladle = FindObjectOfType<LadleServe>();
        if (gameManager.gameOn)
        {
            serving = true;
            addedForce = 4.5f;
            gameManager.InstTimer();
            ChooseBall(); // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
        }
        serving = true;
        addedForce = 4.5f;
        sprite = GetComponent<SpriteRenderer>();       
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
                    //LaunchBall();
                    ladle.serving = true;
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
        velocityX = rb.velocity.x;
        addedForce += 0.001f;
	}

    private void OnCollisionEnter(Collision collision)
    {
        sfxMan.racquetImpact.pitch = Random.Range(0.5f, 1.5f);
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
            sfxMan.failSplat.Play();
            emisMod.rateOverTime = 0;
            Invoke("LaunchBall", 2);
        }
        if (!rb.isKinematic)
        {
            sfxMan.racquetImpact.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            sortingOrder = 0;
            sprite.sortingOrder = sortingOrder;
            Instantiate(splatter, other.gameObject.transform.position, Quaternion.Euler(-90, 0, 0));
            sfxMan.scoreSploosh.Play();
        }

        if (other.tag == "Ladle")
        {
            LaunchBall();
            ladle.serving = false;
            //other.isTrigger = false;
        }
    }

    public void LaunchBall()
    {
        sortingOrder = 3;
        sprite.sortingOrder = sortingOrder;
        transform.position = startingPosition;
        serving = false;
        rb.useGravity = true;
        rb.isKinematic = false;
        rb.velocity = Vector3.zero;
        rb.velocity = new Vector3(gameManager.whichDirection, serveStrength, 0);
        emisMod.rateOverTime = 5;
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
