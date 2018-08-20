using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Char7 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject char7;

    void Start()
    {
        char7.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        char7.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        char7.SetActive(false);
    }
}