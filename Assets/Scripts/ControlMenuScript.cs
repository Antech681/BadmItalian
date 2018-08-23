using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMenuScript : MonoBehaviour {

    Transform menuPanel;
    Event keyEvent;
    Text buttonText;
    KeyCode newKey;

    bool waitingForKey;

	// Use this for initialization
	void Start () {
        menuPanel = transform.Find("SettingsControlsTab");
        //menuPanel.gameObject.SetActive(false);
        waitingForKey = false;

        for(int i = 0; i < 8; i++)
        {
            if(menuPanel.GetChild(i).name == "P1LeftKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = ControlsManager.CM.p1Left.ToString();
            }
            else if (menuPanel.GetChild(i).name == "P1RightKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = ControlsManager.CM.p1Right.ToString();
            }
            else if (menuPanel.GetChild(i).name == "P1SwingLKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = ControlsManager.CM.p1SwingL.ToString();
            }
            else if (menuPanel.GetChild(i).name == "P1SwingRKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = ControlsManager.CM.p1SwingR.ToString();
            }
            else if (menuPanel.GetChild(i).name == "P2LeftKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = ControlsManager.CM.p2Left.ToString();
            }
            else if (menuPanel.GetChild(i).name == "P2RightKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = ControlsManager.CM.p2Right.ToString();
            }
            else if (menuPanel.GetChild(i).name == "P2SwingLKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = ControlsManager.CM.p2SwingL.ToString();
            }
            else if (menuPanel.GetChild(i).name == "P2SwingRKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = ControlsManager.CM.p2SwingR.ToString();
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown(KeyCode.Escape) && !menuPanel.gameObject.activeSelf)
        {
            menuPanel.gameObject.SetActive(true);
            Time.timeScale = 0f;
        } else if (Input.GetKeyDown(KeyCode.Escape) && menuPanel.gameObject.activeSelf)
        {
            menuPanel.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }*/
    }

    private void OnGUI()
    {
        keyEvent = Event.current;

        if(keyEvent.isKey && waitingForKey)
        {
            newKey = keyEvent.keyCode;
            waitingForKey = false;
        }
    }

    public void StartAssignment(string keyName)
    {
        if (!waitingForKey)
        {
            StartCoroutine(AssignKey(keyName));
        }
    }

    public void SendText(Text text)
    {
        buttonText = text;
    }

    IEnumerator WaitForKey()
    {
        while (!keyEvent.isKey)
        {
            yield return null;
        }
    }

    public IEnumerator AssignKey(string keyName)
    {
        waitingForKey = true;

        yield return WaitForKey();

        switch (keyName)
        {
            case "p1Left":
                ControlsManager.CM.p1Left = newKey;
                buttonText.text = ControlsManager.CM.p1Left.ToString();
                PlayerPrefs.SetString("p1LeftKey", ControlsManager.CM.p1Left.ToString());
                break;
            case "p1Right":
                ControlsManager.CM.p1Right = newKey;
                buttonText.text = ControlsManager.CM.p1Right.ToString();
                PlayerPrefs.SetString("p1RightKey", ControlsManager.CM.p1Right.ToString());
                break;
            case "p1SwingL":
                ControlsManager.CM.p1SwingL = newKey;
                buttonText.text = ControlsManager.CM.p1SwingL.ToString();
                PlayerPrefs.SetString("p1SwingLKey", ControlsManager.CM.p1SwingL.ToString());
                break;
            case "p1SwingR":
                ControlsManager.CM.p1SwingR = newKey;
                buttonText.text = ControlsManager.CM.p1SwingR.ToString();
                PlayerPrefs.SetString("p1SwingRKey", ControlsManager.CM.p1SwingR.ToString());
                break;
            case "p2Left":
                ControlsManager.CM.p2Left = newKey;
                buttonText.text = ControlsManager.CM.p2Left.ToString();
                PlayerPrefs.SetString("p2LeftKey", ControlsManager.CM.p2Left.ToString());
                break;
            case "p2Right":
                ControlsManager.CM.p2Right = newKey;
                buttonText.text = ControlsManager.CM.p2Right.ToString();
                PlayerPrefs.SetString("p2RightKey", ControlsManager.CM.p2Right.ToString());
                break;
            case "p2SwingL":
                ControlsManager.CM.p2SwingL = newKey;
                buttonText.text = ControlsManager.CM.p2SwingL.ToString();
                PlayerPrefs.SetString("p2SwingLKey", ControlsManager.CM.p2SwingL.ToString());
                break;
            case "p2SwingR":
                ControlsManager.CM.p1SwingR = newKey;
                buttonText.text = ControlsManager.CM.p2SwingR.ToString();
                PlayerPrefs.SetString("p2SwingRKey", ControlsManager.CM.p2SwingR.ToString());
                break;
        }

        yield return null;
    }
}
