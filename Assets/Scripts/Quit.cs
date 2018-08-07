using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Quit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

    public GameObject quitText;

    void Start()
    {
        quitText.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        quitText.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        quitText.SetActive(false);
    }
}