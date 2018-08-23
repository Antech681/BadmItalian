using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsManager : MonoBehaviour {

    public static ControlsManager CM;

    public KeyCode p1Left { get; set; }
    public KeyCode p1Right { get; set; }
    public KeyCode p1SwingL { get; set; }
    public KeyCode p1SwingR { get; set; }
    public KeyCode p2Left { get; set; }
    public KeyCode p2Right { get; set; }
    public KeyCode p2SwingL { get; set; }
    public KeyCode p2SwingR { get; set; }

    private void Awake()
    {
        if (CM == null)
        {
            DontDestroyOnLoad(gameObject);
            CM = this;
        }
        else if (CM != this)
        {
            Destroy(gameObject);
        }

        p1Left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p1LeftKey", "A"));
        p1Right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p1RightKey", "D"));
        p1SwingL = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p1SwingLKey", "V"));
        p1SwingR = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p1SwingRKey", "B"));
        p2Left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p2LeftKey", "LeftArrow"));
        p2Right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p2RightKey", "RightArrow"));
        p2SwingL = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p2SwingLKey", "Comma"));
        p2SwingR = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p2SwingRKey", "Period"));
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
