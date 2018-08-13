using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadleServe : MonoBehaviour {

    private GameplayManager gameManager;

    private Animator anim;
    public int serveTo;
    public bool serving;

	// Use this for initialization
	void Start () {
        gameManager = FindObjectOfType<GameplayManager>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        serveTo = gameManager.serveTo;

        anim.SetInteger("serveTo", serveTo);
        anim.SetBool("serving", serving);
	}
}
