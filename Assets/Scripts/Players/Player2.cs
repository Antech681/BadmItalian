using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour {

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
        if (CharSelect.chef2Selected == 1)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef1;
        }
        if (CharSelect.chef2Selected == 2)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef2;
        }
        if (CharSelect.chef2Selected == 3)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef3;
        }
        if (CharSelect.chef2Selected == 4)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef4;
        }
        if (CharSelect.chef2Selected == 5)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef5;
        }
        if (CharSelect.chef2Selected == 6)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef6;
        }
        if (CharSelect.chef2Selected == 7)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef7;
        }
        if (CharSelect.chef2Selected == 8)
        {
            GetComponent<SpriteRenderer>().sprite = currentChef8;
        }
    }
}
