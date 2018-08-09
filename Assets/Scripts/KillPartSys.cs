using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPartSys : MonoBehaviour {

    private ParticleSystem partSys;
    private float duration;

	// Use this for initialization
	void Start () {
        partSys = GetComponent<ParticleSystem>();
        duration = partSys.startLifetime;
        Destroy(gameObject, duration);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
