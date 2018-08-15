using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour {

    private static bool vmExists;

    public VolumeController[] vcObjects;
    public float maxVolumeLevel = 1.0f;
    public float currentVolumeLevel;

	// Use this for initialization
	void Start () {
        vcObjects = FindObjectsOfType<VolumeController>();

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
    }
}
