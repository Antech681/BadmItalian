using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WhichPlayerSwinging
{
    P1,
    P2
}

public class SwingingScript : MonoBehaviour {

    public WhichPlayerSwinging whichPlayer;

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
        switch (whichPlayer)
        {
            case WhichPlayerSwinging.P1:
                if (Input.GetKeyDown(GameplayManager.GM.p1SwingL))
                {
                    //rb.AddForce(new Vector3(-hitForce, 0, 0), ForceMode.VelocityChange);
                    rb.velocity = new Vector3(-hitForce, 0);
                    sfxMan.racquetSwing.Play();
                }
                if (Input.GetKeyDown(GameplayManager.GM.p1SwingR))
                {
                    //rb.AddForce(new Vector3(hitForce, 0, 0), ForceMode.VelocityChange);
                    rb.velocity = new Vector3(hitForce, 0);
                    sfxMan.racquetSwing.Play();
                }

                break;

            case WhichPlayerSwinging.P2:
                if (Input.GetKeyDown(GameplayManager.GM.p2SwingL))
                {
                    //rb.AddForce(new Vector3(-hitForce, 0, 0), ForceMode.VelocityChange);
                    rb.velocity = new Vector3(-hitForce, 0);
                    sfxMan.racquetSwing.Play();
                }
                if (Input.GetKeyDown(GameplayManager.GM.p2SwingR))
                {
                    //rb.AddForce(new Vector3(hitForce, 0, 0), ForceMode.VelocityChange);
                    rb.velocity = new Vector3(hitForce, 0);
                    sfxMan.racquetSwing.Play();
                }

                break;
        }
    }
}
