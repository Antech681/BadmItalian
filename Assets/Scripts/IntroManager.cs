using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour {

    public Text p1NameText;
    public Text p2NameText;
    public float delay = 3;
    public string newScene = "Game";

	void Start ()
    {
        p1NameText.text = CharSelect.p1PlayerName;
        p2NameText.text = CharSelect.p2PlayerName;
        StartCoroutine(LoadSceneAfterDelay(delay));
	}

    IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(newScene);
    }
}
