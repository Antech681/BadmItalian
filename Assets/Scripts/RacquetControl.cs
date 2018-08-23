using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WhichPlayer
{
    P1,
    P2
}

public class RacquetControl : MonoBehaviour {

    public WhichPlayer whichPlayer;
    private Rigidbody rb;

    public float moveSpeed;
    public bool canMove = true;

    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode hitLeft;
    public KeyCode hitRight;

    public float posXMin;
    public float posXMax;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
		/*switch (whichPlayer)
        {
            case WhichPlayer.P1:
                moveLeft = KeyCode.A;
                moveRight = KeyCode.D;
                hitLeft = KeyCode.V;
                hitRight = KeyCode.B;

                break;

            case WhichPlayer.P2:
                moveLeft = KeyCode.LeftArrow;
                moveRight = KeyCode.RightArrow;
                hitLeft = KeyCode.Comma;
                hitRight = KeyCode.Period;

                break;
        }*/
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = Vector3.zero;
		if (canMove)
        {
            switch (whichPlayer)
            {
                case WhichPlayer.P1:
                    if (Input.GetKey(ControlsManager.CM.p1Left))
                    {
                        if (transform.position.x >= posXMin)
                        {
                            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
                        }
                    }
                    if (Input.GetKey(ControlsManager.CM.p1Right))
                    {
                        if (transform.position.x <= posXMax)
                        {
                            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
                        }
                    }

                    break;

                case WhichPlayer.P2:
                    if (Input.GetKey(ControlsManager.CM.p2Left))
                    {
                        if (transform.position.x >= posXMin)
                        {
                            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
                        }
                    }
                    if (Input.GetKey(ControlsManager.CM.p2Right))
                    {
                        if (transform.position.x <= posXMax)
                        {
                            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
                        }
                    }

                    break;
            }
            
        }
    }
}
