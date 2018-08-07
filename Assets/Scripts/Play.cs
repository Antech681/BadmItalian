using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Play : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{
    
    public GameObject playText;

    void Start()
    {
        playText.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        playText.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        playText.SetActive(false);
    }
}