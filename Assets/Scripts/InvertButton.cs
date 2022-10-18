using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InvertButton : MonoBehaviour
{
    static Color defaultColor;

    void Start()
    {
        defaultColor = GetComponent<Graphic>().color;
    }

    public void ChangeColour()
    {
        if (GetComponent<Graphic>().color == defaultColor)
            GetComponent<Graphic>().color = Color.red;
        else
            GetComponent<Graphic>().color = defaultColor;
    }
}
