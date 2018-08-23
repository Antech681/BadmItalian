using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kitchen2 : MonoBehaviour {

    public static int arenaSelected;
    public static int selectedKitchen;

    public GameObject backgroundKitchen;

    public Sprite kitchen1;
    public Sprite kitchen2;
    public Sprite kitchen3;
    public Sprite kitchen4;
    public Sprite kitchen5;
    public Sprite kitchen6;

    public GameObject backing1;
    public GameObject backing2;
    public GameObject backing3;
    public GameObject backing4;
    public GameObject backing5;
    public GameObject backing6;

    public Color ready;
    public Color unready;

    void Update()
    {
        arenaSelected = 0;
        backgroundKitchen.SetActive(false);

        backing1.GetComponent<Image>().color = unready;
        backing2.GetComponent<Image>().color = unready;
        backing3.GetComponent<Image>().color = unready;
        backing4.GetComponent<Image>().color = unready;
        backing5.GetComponent<Image>().color = unready;
        backing6.GetComponent<Image>().color = unready;

        BackgroundChange();
    }

    void BackgroundChange()
    {
        switch (selectedKitchen)
        {
            case 1:
                arenaSelected = 1;
                backgroundKitchen.SetActive(true);
                backgroundKitchen.GetComponent<Image>().sprite = kitchen1;
                backing1.GetComponent<Image>().color = ready;
                break;
            case 2:
                arenaSelected = 2;
                backgroundKitchen.SetActive(true);
                backgroundKitchen.GetComponent<Image>().sprite = kitchen2;
                backing2.GetComponent<Image>().color = ready;
                break;
            case 3:
                arenaSelected = 3;
                backgroundKitchen.SetActive(true);
                backgroundKitchen.GetComponent<Image>().sprite = kitchen3;
                backing3.GetComponent<Image>().color = ready;
                break;
            case 4:
                arenaSelected = 4;
                backgroundKitchen.SetActive(true);
                backgroundKitchen.GetComponent<Image>().sprite = kitchen4;
                backing4.GetComponent<Image>().color = ready;
                break;
            case 5:
                arenaSelected = 5;
                backgroundKitchen.SetActive(true);
                backgroundKitchen.GetComponent<Image>().sprite = kitchen5;
                backing5.GetComponent<Image>().color = ready;
                break;
            case 6:
                arenaSelected = 6;
                backgroundKitchen.SetActive(true);
                backgroundKitchen.GetComponent<Image>().sprite = kitchen6;
                backing6.GetComponent<Image>().color = ready;
                break;
            default:
                arenaSelected = 0;
                backgroundKitchen.SetActive(false);
                break;
        }
    }
}
