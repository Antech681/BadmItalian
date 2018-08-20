using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {

    public AudioSource racquetImpact;
    public AudioSource racquetSwing;
    public AudioSource failSplat;
    public AudioSource scoreSploosh;
    public AudioSource roundVictory;
    public AudioSource ladleSwing;
    public AudioSource buttonClick;
    public AudioSource buttonHover;
    public AudioSource dramaticVS;

    private static bool sfxManExists;

	// Use this for initialization
	void Start () {
		if (!sfxManExists)
        {
            sfxManExists = true;
            DontDestroyOnLoad(transform.gameObject);
        } else
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
