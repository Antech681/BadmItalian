using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServeTimer : MonoBehaviour {

    public float time = 3;
    private string timeString;
    public Text timerText;

	// Use this for initialization
	void Start ()
    {
        //StartCoroutine(TheFinalCountDown()); // Don't worry about the coroutine, it didn't work out.
	}

    // Update is called once per frame
    void Update() {
        time -= Time.deltaTime;
        timeString = Mathf.CeilToInt(time).ToString();
        timerText.text = timeString;

        if (time < 0)
        {
            GetComponent<Text>().enabled = false;
        }
	}

    public void StartCountdown()
    {
        time = 3;
        GetComponent<Text>().enabled = true;
    }

    /*IEnumerator TheFinalCountDown()
    {
        while (time > -1)
        {
            yield return new WaitForSeconds(1);
            time -= 1;

            print(time);
            timerText.text = time.ToString();

            if (time == 0)
            {
                //do thing that launches ball (Static vars)
                print("Ball In Play");
            }


        }
        print("DONE");

        Destroy(gameObject);
    }*/
}
