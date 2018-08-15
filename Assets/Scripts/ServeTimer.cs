using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServeTimer : MonoBehaviour {

    public float time = 3;
    private string timeString;
    public Text timerText;
    public GameObject timerText2;

    // Use this for initialization
    void Start ()
    {
        //StartCoroutine(TheFinalCountDown()); // Don't worry about the coroutine, it didn't work out.
	}

    // Update is called once per frame
    void Update() {
        time -= Time.deltaTime;
        timeString = Mathf.CeilToInt(time).ToString();
        timerText.text = "00:0" + timeString;

        if (time < 0)
        {
            GetComponent<Text>().enabled = false;
            timerText2.SetActive(true);
        }
	}

    public void StartCountdown()
    {
        time = 3;
        GetComponent<Text>().enabled = true;
        timerText2.SetActive(false);
    }
}
