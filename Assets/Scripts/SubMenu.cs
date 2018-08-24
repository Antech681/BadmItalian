using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubMenu : MonoBehaviour
{
    public Button resume;

    private void Start()
    {
        resume = GameObject.Find("Continue").GetComponent<Button>();
    }

    void Update()
    {
        resume.GetComponent<Button>().onClick.AddListener(ContinueScene);
    }

    void ContinueScene()
    {
        SceneManager.LoadScene("Player Select");
    }
}
