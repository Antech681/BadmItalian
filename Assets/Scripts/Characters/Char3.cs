using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Char3 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject char3;

    void Start()
    {
        char3.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        char3.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        char3.SetActive(false);
    }
}