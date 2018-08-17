using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSounds : MonoBehaviour {

    private SFXManager sfxMan;

	// Use this for initialization
	void Start () {
        sfxMan = FindObjectOfType<SFXManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayHoverSound()
    {
        sfxMan.buttonHover.pitch = Random.Range(0.8f, 1.2f);
        sfxMan.buttonHover.Play();
    }

    public void PlayClickSound()
    {
        sfxMan.buttonClick.pitch = Random.Range(0.8f, 1.2f);
        sfxMan.buttonClick.Play();
    }
}
