using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour {
    
    private MusicController theMC;
    [Tooltip("0 = Title, 1 = Controls, 2 = Gameplay, 3 = Credits, 4 = Victory Screen")]
    public int newTrack;
    public bool switchOnStart;

	// Use this for initialization
	void Start () {
        theMC = FindObjectOfType<MusicController>();

        if (switchOnStart)
        {
            theMC.SwitchTrack(newTrack);
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
