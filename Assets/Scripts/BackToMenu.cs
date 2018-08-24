using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour {

    public Canvas mainMenu;
    public Canvas settings;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToMainMenu()
    {
        mainMenu.gameObject.SetActive(true);
        settings.gameObject.SetActive(false);
    }
}
