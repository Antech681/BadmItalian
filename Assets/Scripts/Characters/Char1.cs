using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Char1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject char1;

    void Start()
    {
        char1.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        char1.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        char1.SetActive(false);
    }
}