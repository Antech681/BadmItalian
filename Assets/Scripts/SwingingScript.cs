using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum WhichPlayerSwinging
{
    P1,
    P2
}

public class SwingingScript : MonoBehaviour {

    public WhichPlayerSwinging whichPlayer;

    public RacquetControl racCon;
    private Rigidbody rb;

    public float startHitForce;
    public float hitForce;
    public float hitForceChargeRate;
    public float hitForceMax;

    public float velocityX;
    public float velocityY;


    private SFXManager sfxMan;

    private Slider powerSlider;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        velocityY = rb.velocity.y;
        sfxMan = FindObjectOfType<SFXManager>();
        switch (whichPlayer)
        {
            case WhichPlayerSwinging.P1:
                powerSlider = GameObject.Find("P1PowerCharge").GetComponent<Slider>();
                break;

            case WhichPlayerSwinging.P2:
                powerSlider = GameObject.Find("P2PowerCharge").GetComponent<Slider>();
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
        switch (whichPlayer)
        {
            case WhichPlayerSwinging.P1:
                if (hitForce >= hitForceMax)
                {
                    hitForce = hitForceMax;
                }
                powerSlider.value = hitForce;
                if (Input.GetKey(ControlsManager.CM.p1SwingL))
                {
                    hitForce += hitForceChargeRate * Time.deltaTime;
                }
                if (Input.GetKey(ControlsManager.CM.p1SwingR))
                {
                    hitForce += hitForceChargeRate * Time.deltaTime;
                }
                if (Input.GetKeyUp(ControlsManager.CM.p1SwingL))
                {
                    if (transform.localPosition.y <= 0)
                    {
                        rb.velocity = new Vector3(-hitForce, 0);
                    }
                    else if (transform.localPosition.y >= 0)
                    {
                        rb.velocity = new Vector3(hitForce, 0);
                    }

                    sfxMan.racquetSwing.Play();
                    hitForce = startHitForce;
                }
                if (Input.GetKeyUp(ControlsManager.CM.p1SwingR))
                {
                    if (transform.localPosition.y <= 0)
                    {
                        rb.velocity = new Vector3(hitForce, 0);
                    }
                    else if (transform.localPosition.y >= 0)
                    {
                        rb.velocity = new Vector3(-hitForce, 0);
                    }
                    sfxMan.racquetSwing.Play();
                    hitForce = startHitForce;
                }

                break;

            case WhichPlayerSwinging.P2:
                if (hitForce >= hitForceMax)
                {
                    hitForce = hitForceMax;
                }
                powerSlider.value = hitForce;
                if (Input.GetKey(ControlsManager.CM.p2SwingL))
                {
                    hitForce += hitForceChargeRate * Time.deltaTime;
                }
                if (Input.GetKey(ControlsManager.CM.p2SwingR))
                {
                    hitForce += hitForceChargeRate * Time.deltaTime;
                }
                if (Input.GetKeyUp(ControlsManager.CM.p2SwingL))
                {
                    //rb.AddForce(new Vector3(-hitForce, 0, 0), ForceMode.VelocityChange);
                    rb.velocity = new Vector3(-hitForce, 0);
                    sfxMan.racquetSwing.Play();
                    hitForce = startHitForce;
                }
                if (Input.GetKeyUp(ControlsManager.CM.p2SwingR))
                {
                    //rb.AddForce(new Vector3(hitForce, 0, 0), ForceMode.VelocityChange);
                    rb.velocity = new Vector3(hitForce, 0);
                    sfxMan.racquetSwing.Play();
                    hitForce = startHitForce;
                }

                break;
        }
    }
}
