using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public int direction = 0;
    public Button dial;
    public Button play;
    public Button settings;
    public Button credits;
    public Button quit;

    public Canvas settingsCanvas;
    public Canvas mainCanvas;
    public Canvas creditsCanvas;

    void Start()
    {
        play.GetComponent<Button>().interactable = true;
        settings.GetComponent<Button>().interactable = false;
        credits.GetComponent<Button>().interactable = false;
        quit.GetComponent<Button>().interactable = false;
        Button btn = dial.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        settingsCanvas.gameObject.SetActive(false);
        creditsCanvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (direction == 4)
        {
            direction = 0;
            credits.GetComponent<Button>().interactable = false;
            play.GetComponent<Button>().interactable = true;
        }
        if (direction == 1)
        {
            play.GetComponent<Button>().interactable = false;
            settings.GetComponent<Button>().interactable = true;
        }
        if (direction == 2)
        {
            settings.GetComponent<Button>().interactable = false;
            quit.GetComponent<Button>().interactable = true;
        }
        if (direction == 3)
        {
            quit.GetComponent<Button>().interactable = false;
            credits.GetComponent<Button>().interactable = true;
        }
        play.GetComponent<Button>().onClick.AddListener(PlayScene);
        quit.GetComponent<Button>().onClick.AddListener(QuitScene);
    }

    void TaskOnClick()
    {
        dial.transform.Rotate(new Vector3(0, 0, -90));
        direction++;
    }

    void PlayScene()
    {
        SceneManager.LoadScene("Controls");
        play.interactable = false;
    }

    void QuitScene()
    {
        Application.Quit();
    }

    public void ActivateSettings()
    {
        settingsCanvas.gameObject.SetActive(true);
        mainCanvas.gameObject.SetActive(false);
    }

    public void ActivateCredits()
    {
        creditsCanvas.gameObject.SetActive(true);
        mainCanvas.gameObject.SetActive(false);
    }
}
