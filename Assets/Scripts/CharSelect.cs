using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharSelect : MonoBehaviour {

    public Button player1;
    public Button player2;

    public static int chefSelected;
    public static int chef2Selected;

    public Color ready;
    public Color unready;

    public Sprite char1R;
    public Sprite char2R;
    public Sprite char3R;
    public Sprite char4R;
    public Sprite char5R;
    public Sprite char6R;
    public Sprite char7R;
    public Sprite char8R;
    public Sprite char1B;
    public Sprite char2B;
    public Sprite char3B;
    public Sprite char4B;
    public Sprite char5B;
    public Sprite char6B;
    public Sprite char7B;
    public Sprite char8B;

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
                SceneManager.LoadScene("Map Select");
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
            p1ConfirmButton.GetComponent<Image>().color = ready;
            p1ConfirmText.text = "READY!";
        }
        if (p2Confirmed)
        {
            p2ConfirmButton.GetComponent<Image>().color = ready;
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
        p1ConfirmButton.GetComponent<Image>().color = unready;
        p1Confirmed = !p1Confirmed;
    }

    public void ToggleP2Confirm()
    {
        p2ConfirmButton.GetComponent<Image>().color = unready;
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
            chefSelected = 1;
            player1.GetComponent<Image>().sprite = char1R;
            p1PlayerName = char1Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            chef2Selected = 1;
            player2.GetComponent<Image>().sprite = char1B;
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
            chefSelected = 2;
            player1.GetComponent<Image>().sprite = char2R;
            p1PlayerName = char2Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            chef2Selected = 2;
            player2.GetComponent<Image>().sprite = char2B;
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
            chefSelected = 3;
            player1.GetComponent<Image>().sprite = char3R;
            p1PlayerName = char3Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            chef2Selected = 3;
            player2.GetComponent<Image>().sprite = char3B;
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
            chefSelected = 4;
            player1.GetComponent<Image>().sprite = char4R;
            p1PlayerName = char4Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            chef2Selected = 4;
            player2.GetComponent<Image>().sprite = char4B;
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
            chefSelected = 5;
            player1.GetComponent<Image>().sprite = char5R;
            p1PlayerName = char5Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            chef2Selected = 5;
            player2.GetComponent<Image>().sprite = char5B;
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
            chefSelected = 6;
            player1.GetComponent<Image>().sprite = char6R;
            p1PlayerName = char6Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            chef2Selected = 6;
            player2.GetComponent<Image>().sprite = char6B;
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
            chefSelected = 7;
            player1.GetComponent<Image>().sprite = char7R;
            p1PlayerName = char7Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            chef2Selected = 7;
            player2.GetComponent<Image>().sprite = char7B;
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
            chefSelected = 8;
            player1.GetComponent<Image>().sprite = char8R;
            p1PlayerName = char8Name;
            playerSelecting = 0;
        }
        else if (playerSelecting == 2)
        {
            chef2Selected = 8;
            player2.GetComponent<Image>().sprite = char8B;
            p2PlayerName = char8Name;
            playerSelecting = 0;
        }
    }
}
