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

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
		switch (whichPlayer)
        {
            case WhichPlayer.P1:
                moveLeft = KeyCode.A;
                moveRight = KeyCode.D;
                hitLeft = KeyCode.Q;
                hitRight = KeyCode.E;

                break;

            case WhichPlayer.P2:
                moveLeft = KeyCode.LeftArrow;
                moveRight = KeyCode.RightArrow;
                hitLeft = KeyCode.Comma;
                hitRight = KeyCode.Period;

                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = Vector3.zero;
		if (canMove)
        {
            if (Input.GetKey(moveLeft))
            {
                transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(moveRight))
            {
                transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            }
        }
	}
}
