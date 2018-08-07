using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public int direction = 0;
    public Button dial;
    public Button play;
    public Button settings;
    public Button credits;
    public Button quit;

    void Start()
    {
        play.GetComponent<Button>().interactable = true;
        settings.GetComponent<Button>().interactable = false;
        credits.GetComponent<Button>().interactable = false;
        quit.GetComponent<Button>().interactable = false;
        Button btn = dial.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
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
    }

    void TaskOnClick()
    {
        dial.transform.Rotate(new Vector3(0, 0, -90));
        direction++;
    }
}
