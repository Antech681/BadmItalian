using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubMenu1 : MonoBehaviour
{
    public Button resume;

    void Update()
    {
        if (Kitchen2.selected == 1)
        {
            resume.GetComponent<Button>().onClick.AddListener(ContinueScene);
        }
    }

    void ContinueScene()
    {
        SceneManager.LoadScene("Game");
    }
}
