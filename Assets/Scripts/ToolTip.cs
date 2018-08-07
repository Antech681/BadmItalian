using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToolTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

    public GameObject smallPanel;
    public GameObject tooltip;
    public Vector3 offset;

    void Start()
    {
        smallPanel.SetActive(false);
        tooltip.SetActive(false);
    }
    void Update()
    {
        smallPanel.transform.position = Input.mousePosition + offset;
        tooltip.transform.position = Input.mousePosition + offset;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        smallPanel.SetActive(true);
        tooltip.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        smallPanel.SetActive(false);
        tooltip.SetActive(false);
    }
}