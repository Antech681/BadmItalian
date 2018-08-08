using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelect : MonoBehaviour {

    public bool p1Confirmed;
    public bool p2Confirmed;

    public string p1PlayerName;
    public string p2PlayerName;
    public int playerSelecting; // 0 = not selecting, 1 = choosing P1, 2 = choosing P2.

    public Text p1NameText;
    public Text p2NameText;
    public Button p1ConfirmButton;
    public Button p2ConfirmButton;
    private Text p1ConfirmText;
    private Text p2ConfirmText;

    public string char1Name;
    public string char2Name;
    public string char3Name;
    public string char4Name;
    public string char5Name;
    public string char6Name;
    public string char7Name;
    public string char8Name;

    // Use this for initialization
    void Start () {
        p1PlayerName = "CLICK TO CHOOSE P1";
        p2PlayerName = "CLICK TO CHOOSE P2";
        playerSelecting = 0;
        p1NameText.text = p1PlayerName;
        p2NameText.text = p2PlayerName;
        p1ConfirmText = p1ConfirmButton.GetComponentInChildren<Text>();
        p2ConfirmText = p2ConfirmButton.GetComponentInChildren<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0))
        {
            p1NameText.text = p1PlayerName;
            p2NameText.text = p2PlayerName;
            if (p1Confirmed && p2Confirmed)
            {
                Debug.Log("SwitchScene");
            }
        }

        if (p1PlayerName != "CLICK TO CHOOSE P1" && p1PlayerName != "CHOOSE YOUR PLAYER")
        {
            p1ConfirmButton.interactable = true;
            p1ConfirmText.text = "CONFIRM";
        }
        else
        {
            p1ConfirmButton.interactable = false;
            p1ConfirmText.text = "-";
        }
        if (p2PlayerName != "CLICK TO CHOOSE P2" && p2PlayerName != "CHOOSE YOUR PLAYER")
        {
            p2ConfirmButton.interactable = true;
            p2ConfirmText.text = "CONFIRM";
        }
        else
        {
            p2ConfirmButton.interactable = false;
            p2ConfirmText.text = "-";
        }

        if (p1Confirmed)
        {
            p1ConfirmText.text = "READY!";
        }
        if (p2Confirmed)
        {
            p2ConfirmText.text = "READY!";
        }
    }

    public void SelectPlayerOne()
    {
        if (!p1Confirmed)
        {
            playerSelecting = 1;
            p1PlayerName = "CHOOSE YOUR PLAYER";
        }
    }

    public void SelectPlayerTwo()
    {
        if (!p2Confirmed)
        {
            playerSelecting = 2;
            p2PlayerName = "CHOOSE YOUR PLAYER";
        }
    }

    public void ToggleP1Confirm()
    {
        p1Confirmed = !p1Confirmed;
    }

    public void ToggleP2Confirm()
    {
        p2Confirmed = !p2Confirmed;
    }

    public void MakeCharOne()
    {
        if (playerSelecting == 0)
        {
            return;
        }
        else if (playerSelecting == 1)
        {
            p1PlayerName = char1Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            p2PlayerName = char1Name;
            playerSelecting = 0;
        }
    }

    public void MakeCharTwo()
    {
        if (playerSelecting == 0)
        {
            return;
        }
        else if (playerSelecting == 1)
        {
            p1PlayerName = char2Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            p2PlayerName = char2Name;
            playerSelecting = 0;
        }
    }

    public void MakeCharThree()
    {
        if (playerSelecting == 0)
        {
            return;
        }
        else if (playerSelecting == 1)
        {
            p1PlayerName = char3Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            p2PlayerName = char3Name;
            playerSelecting = 0;
        }
    }

    public void MakeCharFour()
    {
        if (playerSelecting == 0)
        {
            return;
        }
        else if (playerSelecting == 1)
        {
            p1PlayerName = char4Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            p2PlayerName = char4Name;
            playerSelecting = 0;
        }
    }

    public void MakeCharFive()
    {
        if (playerSelecting == 0)
        {
            return;
        }
        else if (playerSelecting == 1)
        {
            p1PlayerName = char5Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            p2PlayerName = char5Name;
            playerSelecting = 0;
        }
    }

    public void MakeCharSix()
    {
        if (playerSelecting == 0)
        {
            return;
        }
        else if (playerSelecting == 1)
        {
            p1PlayerName = char6Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            p2PlayerName = char6Name;
            playerSelecting = 0;
        }
    }

    public void MakeCharSeven()
    {
        if (playerSelecting == 0)
        {
            return;
        }
        else if (playerSelecting == 1)
        {
            p1PlayerName = char7Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            p2PlayerName = char7Name;
            playerSelecting = 0;
        }
    }

    public void MakeCharEight()
    {
        if (playerSelecting == 0)
        {
            return;
        }
        else if (playerSelecting == 1)
        {
            p1PlayerName = char8Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            p2PlayerName = char8Name;
            playerSelecting = 0;
        }
    }
}
