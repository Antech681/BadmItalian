using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Settings : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

    public GameObject settingsText;

    void Start()
    {
        settingsText.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        settingsText.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        settingsText.SetActive(false);
    }
}