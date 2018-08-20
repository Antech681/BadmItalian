using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Char2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject char2;

    void Start()
    {
        char2.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        char2.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        char2.SetActive(false);
    }
}