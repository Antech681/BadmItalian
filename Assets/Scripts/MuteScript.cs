using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteScript : MonoBehaviour {
    
    public Slider volumeSlider;
    public VolumeManager volMan;
    public Toggle toggle;
    
    void Start () {
        //audioSource = GetComponent<AudioSource>();
        //volumeSlider = GameObject.Find("VolumeControlBar").GetComponent<Slider>();
        //volMan = GameObject.Find("VolumeManager").GetComponent<VolumeManager>();
        //toggle = GameObject.Find("Mute").GetComponent<Toggle>();
	}
	
	void Update () {
		
	}

    public void ToggleMute(bool isMuted)
    {
        //audioSource.mute = !audioSource.mute;
        for (int i = 0; i < volMan.vcObjects.Length; i++)
        {
            volMan.vcObjects[i].GetComponent<AudioSource>().mute = !volMan.vcObjects[i].GetComponent<AudioSource>().mute;
        }
    }

    /*public void CheckIfSound()
    {
        if (volumeSlider.value > 0)
        {
            toggle.isOn = false;
        }
        if (volumeSlider.value == 0)
        {
            toggle.isOn = true;
        }
    }*/
}
