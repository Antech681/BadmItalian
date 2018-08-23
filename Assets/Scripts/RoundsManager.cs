using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsManager : MonoBehaviour {

    public static RoundsManager roundMan;
    public Slider slider;
    public Text roundsText;
    public int pointsToWin;

	// Use this for initialization
	void Start () {
        if (roundMan == null)
        {
            DontDestroyOnLoad(gameObject);
            roundMan = this;
        }
        else if (roundMan != this)
        {
            Destroy(gameObject);
        }
        slider = GameObject.Find("RoundsSlider").GetComponent<Slider>();
        roundsText = GameObject.Find("RoundNoText").GetComponent<Text>();
        pointsToWin = Mathf.RoundToInt(slider.value);
        roundsText.text = pointsToWin.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeRounds()
    {
        pointsToWin = Mathf.RoundToInt(slider.value);
        roundsText.text = pointsToWin.ToString();
    }
}
