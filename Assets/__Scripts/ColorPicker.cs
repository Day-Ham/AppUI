using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] private StyleBox test;
    [SerializeField] private StyleBoxUI prompt;
    [SerializeField] private FlexibleColorPicker picker;
    [SerializeField] private bool isColor =true;

   


    public void SetColor()
    {
        if (isColor)
        {
            test.color = picker.color;
        }
        else
        {
            test.hightLight = picker.color;
        }
        prompt.UpdateData();
    }
}
