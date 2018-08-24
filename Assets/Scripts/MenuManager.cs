using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject mainPanel;
    public GameObject creditsPanel;

    public Animator anim;

    public GameObject creditsText;
    public bool movingCredits;

    void Update()
    {

    }

    public void Credits()
    {
        mainPanel.SetActive(false);
        creditsPanel.SetActive(true);
        anim.SetBool("creditsIsRolling", movingCredits);
        movingCredits = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
