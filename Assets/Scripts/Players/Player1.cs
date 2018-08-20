using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour {

    public Sprite currentChef1;
    public Sprite currentChef2;
    public Sprite currentChef3;
    public Sprite currentChef4;
    public Sprite currentChef5;
    public Sprite currentChef6;
    public Sprite currentChef7;
    public Sprite currentChef8;

    void Update()
    {
        //currentPlayer1 = CharSelect.currentPlayer1.GetComponent<Image>().sprite;
        //GetComponent<SpriteRenderer>().sprite = currentPlayer1;
        if (CharSelect.chefSelected == 1)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef1;
        }
        if (CharSelect.chefSelected == 2)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef2;
        }
        if (CharSelect.chefSelected == 3)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef3;
        }
        if (CharSelect.chefSelected == 4)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef4;
        }
        if (CharSelect.chefSelected == 5)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef5;
        }
        if (CharSelect.chefSelected == 6)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef6;
        }
        if (CharSelect.chefSelected == 7)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef7;
        }
        if (CharSelect.chefSelected == 8)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef8;
        }
    }
}
