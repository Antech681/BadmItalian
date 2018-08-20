using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kitchen2 : MonoBehaviour {

    public GameObject kitchen1;
    public GameObject kitchen2;
    public GameObject kitchen3;
    public GameObject kitchen4;
    public GameObject kitchen5;
    public GameObject kitchen6;

    public GameObject backing1;
    public GameObject backing2;
    public GameObject backing3;
    public GameObject backing4;
    public GameObject backing5;
    public GameObject backing6;
    public Color ready;
    public Color unready;

    public int selectedKitchen1;
    public int selectedKitchen2;
    public int selectedKitchen3;
    public int selectedKitchen4;
    public int selectedKitchen5;
    public int selectedKitchen6;

    public bool confirmed;
    public static int selected;

    void Update()
    {
        kitchen1.GetComponent<Button>().onClick.AddListener(Task1);
        kitchen2.GetComponent<Button>().onClick.AddListener(Task2);
        kitchen3.GetComponent<Button>().onClick.AddListener(Task3);
        kitchen4.GetComponent<Button>().onClick.AddListener(Task4);
        kitchen5.GetComponent<Button>().onClick.AddListener(Task5);
        kitchen6.GetComponent<Button>().onClick.AddListener(Task6);
        if (selectedKitchen1 == 1)
        {
            kitchen1.GetComponent<Button>().onClick.AddListener(Task7);
        }
        if (selectedKitchen2 == 1)
        {
            kitchen2.GetComponent<Button>().onClick.AddListener(Task8);
        }
        if (selectedKitchen3 == 1)
        {
            kitchen3.GetComponent<Button>().onClick.AddListener(Task9);
        }
        if (selectedKitchen4 == 1)
        {
            kitchen4.GetComponent<Button>().onClick.AddListener(Task10);
        }
        if (selectedKitchen5 == 1)
        {
            kitchen5.GetComponent<Button>().onClick.AddListener(Task11);
        }
        if (selectedKitchen6 == 1)
        {
            kitchen6.GetComponent<Button>().onClick.AddListener(Task12);
        }
        if (confirmed)
        {
            selected = 1;
        }
    }

    public void Task1()
    {
        selectedKitchen1 = 1;
        backing1.GetComponent<Image>().color = ready;
        backing2.GetComponent<Image>().color = unready;
        backing3.GetComponent<Image>().color = unready;
        backing4.GetComponent<Image>().color = unready;
        backing5.GetComponent<Image>().color = unready;
        backing6.GetComponent<Image>().color = unready;
    }
    public void Task7()
    {
        selectedKitchen1 = 0;
        backing1.GetComponent<Image>().color = unready;
    }

    public void Task2()
    {
        selectedKitchen2 = 1;
        backing2.GetComponent<Image>().color = ready;
        backing1.GetComponent<Image>().color = unready;
        backing3.GetComponent<Image>().color = unready;
        backing4.GetComponent<Image>().color = unready;
        backing5.GetComponent<Image>().color = unready;
        backing6.GetComponent<Image>().color = unready;
    }
    public void Task8()
    {
        selectedKitchen2 = 0;
        backing2.GetComponent<Image>().color = unready;
    }

    public void Task3()
    {
        selectedKitchen3 = 1;
        backing3.GetComponent<Image>().color = ready;
        backing2.GetComponent<Image>().color = unready;
        backing1.GetComponent<Image>().color = unready;
        backing4.GetComponent<Image>().color = unready;
        backing5.GetComponent<Image>().color = unready;
        backing6.GetComponent<Image>().color = unready;
    }
    public void Task9()
    {
        selectedKitchen3 = 0;
        backing3.GetComponent<Image>().color = unready;
    }

    public void Task4()
    {
        selectedKitchen4 = 1;
        backing4.GetComponent<Image>().color = ready;
        backing2.GetComponent<Image>().color = unready;
        backing3.GetComponent<Image>().color = unready;
        backing1.GetComponent<Image>().color = unready;
        backing5.GetComponent<Image>().color = unready;
        backing6.GetComponent<Image>().color = unready;
    }
    public void Task10()
    {
        selectedKitchen4 = 0;
        backing4.GetComponent<Image>().color = unready;
    }

    public void Task5()
    {
        selectedKitchen5 = 1;
        backing5.GetComponent<Image>().color = ready;
        backing2.GetComponent<Image>().color = unready;
        backing3.GetComponent<Image>().color = unready;
        backing1.GetComponent<Image>().color = unready;
        backing4.GetComponent<Image>().color = unready;
        backing6.GetComponent<Image>().color = unready;
    }
    public void Task11()
    {
        selectedKitchen5 = 0;
        backing5.GetComponent<Image>().color = unready;
    }

    public void Task6()
    {
        selectedKitchen6 = 1;
        backing6.GetComponent<Image>().color = ready;
        backing2.GetComponent<Image>().color = unready;
        backing3.GetComponent<Image>().color = unready;
        backing1.GetComponent<Image>().color = unready;
        backing5.GetComponent<Image>().color = unready;
        backing4.GetComponent<Image>().color = unready;
    }
    public void Task12()
    {
        selectedKitchen6 = 0;
        backing6.GetComponent<Image>().color = unready;
    }

    public void ToggleConfirm()
    {
        selected = 0;
        confirmed = !confirmed;
    }
}
