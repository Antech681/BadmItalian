using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Profile : MonoBehaviour
{

    public Texture currentChef1;
    public Texture currentChef2;
    public Texture currentChef3;
    public Texture currentChef4;
    public Texture currentChef5;
    public Texture currentChef6;
    public Texture currentChef7;
    public Texture currentChef8;

    void Update()
    {
        //currentPlayer1 = CharSelect.currentPlayer1.GetComponent<Image>().sprite;
        //GetComponent<SpriteRenderer>().sprite = currentPlayer1;
        if (CharSelect.chef2Selected == 1)
        {
            GetComponent<RawImage>().texture = currentChef1;
        }
        if (CharSelect.chef2Selected == 2)
        {
            GetComponent<RawImage>().texture = currentChef2;
        }
        if (CharSelect.chef2Selected == 3)
        {
            GetComponent<RawImage>().texture = currentChef3;
        }
        if (CharSelect.chef2Selected == 4)
        {
            GetComponent<RawImage>().texture = currentChef4;
        }
        if (CharSelect.chef2Selected == 5)
        {
            GetComponent<RawImage>().texture = currentChef5;
        }
        if (CharSelect.chef2Selected == 6)
        {
            GetComponent<RawImage>().texture = currentChef6;
        }
        if (CharSelect.chef2Selected == 7)
        {
            GetComponent<RawImage>().texture = currentChef7;
        }
        if (CharSelect.chef2Selected == 8)
        {
            GetComponent<RawImage>().texture = currentChef8;
        }
    }
}
