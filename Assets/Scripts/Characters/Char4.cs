using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Char4 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject char4;

    void Start()
    {
        char4.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        char4.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        char4.SetActive(false);
    }
}