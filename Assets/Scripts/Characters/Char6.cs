using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Char6 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject char6;

    void Start()
    {
        char6.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        char6.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        char6.SetActive(false);
    }
}