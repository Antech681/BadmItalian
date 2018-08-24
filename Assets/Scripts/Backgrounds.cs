using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backgrounds : MonoBehaviour
{
    public GameObject kitchenBench;
    public Sprite currentKitchen1;
    public Sprite currentKitchen2;
    public Sprite currentKitchen3;
    public Sprite currentKitchen4;
    public Sprite currentKitchen5;
    public Sprite currentKitchen6;

    void Start()
    {
        //currentPlayer1 = CharSelect.currentPlayer1.GetComponent<Image>().sprite;
        //GetComponent<SpriteRenderer>().sprite = currentPlayer1;
        if (Kitchen2.arenaSelected == 1)
        {
            kitchenBench.transform.position = new Vector3(0, -5.25f, 0);
            GetComponent<SpriteRenderer>().sprite = currentKitchen1;
        }
        if (Kitchen2.arenaSelected == 2)
        {
            kitchenBench.transform.position = new Vector3(0, -5.25f, 0);
            GetComponent<SpriteRenderer>().sprite = currentKitchen2;
        }
        if (Kitchen2.arenaSelected == 3)
        {
            kitchenBench.transform.position = new Vector3(0, -5.25f, 0);
            GetComponent<SpriteRenderer>().sprite = currentKitchen3;
        }
        if (Kitchen2.arenaSelected == 4)
        {
            kitchenBench.transform.position = new Vector3(0, -5.25f, 0);
            GetComponent<SpriteRenderer>().sprite = currentKitchen4;
        }
        if (Kitchen2.arenaSelected == 5)
        {
            kitchenBench.transform.position = new Vector3(0, -4.38f, 0);
            GetComponent<SpriteRenderer>().sprite = currentKitchen5;
        }
        if (Kitchen2.arenaSelected == 6)
        {
            kitchenBench.transform.position = new Vector3(0, -5.25f, 0);
            GetComponent<SpriteRenderer>().sprite = currentKitchen6;
        }
    }
}
