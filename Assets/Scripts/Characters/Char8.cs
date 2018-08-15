using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Char8 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject char8;

    void Start()
    {
        char8.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        char8.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        char8.SetActive(false);
    }
}