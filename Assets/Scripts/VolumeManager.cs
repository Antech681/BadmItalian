using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour {

    private static bool vmExists;

    public VolumeController[] vcObjects;
    public float maxVolumeLevel = 1.0f;
    public float currentVolumeLevel;

    public Slider volumeSlider;
    private Text volumeText;

	// Use this for initialization
	void Start () {
        vcObjects = FindObjectsOfType<VolumeController>();

<<<<<<< HEAD
        if (volumeSlider == null)
        {
            return;
        }

        volumeText = volumeSlider.GetComponentInChildren<Text>();
	}
        if (!vmExists)
        {
            vmExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (currentVolumeLevel > maxVolumeLevel)
        {
            currentVolumeLevel = maxVolumeLevel;
        }
        if (currentVolumeLevel < 0)
        {
            currentVolumeLevel = 0;
        }

        for (int i = 0; i < vcObjects.Length; i++)
        {
            vcObjects[i].SetAudioLevel(currentVolumeLevel);
        }

        currentVolumeLevel = volumeSlider.value;
        volumeText.text = Mathf.RoundToInt(volumeSlider.value * 100) + "%";
    }
}
