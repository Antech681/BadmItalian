using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

    public static bool mcExists;

    public AudioSource[] musicTracks;
    public int currentTrack;
    public bool musicCanPlay;

    public bool gamePaused;

	// Use this for initialization
	void Start () {
        if (!mcExists)
        {
            mcExists = true;
            DontDestroyOnLoad(transform.gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (musicCanPlay)
        {
            if (!musicTracks[currentTrack].isPlaying)
            {
                musicTracks[currentTrack].Play();
            }
        }
        else
        {
            musicTracks[currentTrack].Stop();
        }

        if (gamePaused)
        {
            musicCanPlay = false; ;
        } else if (!gamePaused)
        {
            musicCanPlay = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gamePaused = !gamePaused;
        }
	}

    public void SwitchTrack(int newTrack)
    {
        musicTracks[currentTrack].Stop();
        currentTrack = newTrack;
        musicTracks[currentTrack].Play();
    }
}
