using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Kitchen1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject kitchen;
    public GameObject otherKitchen;
    public Sprite kitchenSprite;

    void Start()
    {
        kitchen.SetActive(false);
        otherKitchen.SetActive(false);
    }

    void Update()
    {
         GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        kitchen.SetActive(false);
        otherKitchen.SetActive(true);
        otherKitchen.GetComponent<Image>().sprite = kitchenSprite;
    }

public void OnPointerEnter(PointerEventData eventData)
    {
        otherKitchen.SetActive(false);
        kitchen.SetActive(true);
        kitchen.GetComponent<Image>().sprite = kitchenSprite;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        kitchen.SetActive(false);
        if (Kitchen2.selected == 1)
        {
            otherKitchen.SetActive(true);
        }
        if (Kitchen2.selected == 0)
        {
            otherKitchen.SetActive(false);
        }
    }
}