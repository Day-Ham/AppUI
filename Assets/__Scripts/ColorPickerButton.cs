using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerButton : MonoBehaviour
{
    private bool toggle = false;
    [SerializeField] private GameObject ColorPicker;
    [SerializeField] private GameObject HighlightPicker;


    public void Toggle()
    {
        toggle = !toggle;
        ColorPicker.SetActive(toggle);
    }
    
    
}
