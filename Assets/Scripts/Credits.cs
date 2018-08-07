using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Credits : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

    public GameObject creditsText;

    void Start()
    {
        creditsText.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        creditsText.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        creditsText.SetActive(false);
    }
}