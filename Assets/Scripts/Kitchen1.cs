using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Kitchen1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool ifPressed;
    public int currentKitchen;

    public GameObject kitchen;
    public Sprite kitchenSprite;

    void Start()
    {
        kitchen.SetActive(false);
    }

    void Update()
    {
        if (ifPressed == true)
        {
            GetComponent<Button>().onClick.AddListener(Unconfirmed);
        }
        else
        {
            GetComponent<Button>().onClick.AddListener(Confirmed);
        }
    }

    void Confirmed()
    {
        ifPressed = true;
        Kitchen2.selectedKitchen = currentKitchen;
        kitchen.SetActive(false);
    }

    void Unconfirmed()
    {
        ifPressed = false;
        Kitchen2.selectedKitchen = 0;
        kitchen.SetActive(false);
    }

public void OnPointerEnter(PointerEventData eventData)
    {
        kitchen.SetActive(true);
        kitchen.GetComponent<Image>().sprite = kitchenSprite;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        kitchen.SetActive(false);
    }
}