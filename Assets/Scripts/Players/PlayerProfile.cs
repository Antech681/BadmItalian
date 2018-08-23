using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfile : MonoBehaviour {

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
        if (CharSelect.chefSelected == 1)
        {
            GetComponent<RawImage>().texture = currentChef1;
        }
        if (CharSelect.chefSelected == 2)
        {
            GetComponent<RawImage>().texture = currentChef2;
        }
        if (CharSelect.chefSelected == 3)
        {
            GetComponent<RawImage>().texture = currentChef3;
        }
        if (CharSelect.chefSelected == 4)
        {
            GetComponent<RawImage>().texture = currentChef4;
        }
        if (CharSelect.chefSelected == 5)
        {
            GetComponent<RawImage>().texture = currentChef5;
        }
        if (CharSelect.chefSelected == 6)
        {
            GetComponent<RawImage>().texture = currentChef6;
        }
        if (CharSelect.chefSelected == 7)
        {
            GetComponent<RawImage>().texture = currentChef7;
        }
        if (CharSelect.chefSelected == 8)
        {
            GetComponent<RawImage>().texture = currentChef8;
        }
    }
}
