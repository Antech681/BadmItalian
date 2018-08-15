using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Char5 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject char5;

    void Start()
    {
        char5.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        char5.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        char5.SetActive(false);
    }
}