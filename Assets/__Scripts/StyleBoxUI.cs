using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StyleBoxUI : MonoBehaviour
{
    [SerializeField] private StyleBox style;
    
    [SerializeField] private Slider Lenght;
    [SerializeField] private Button ColorButton;
    [SerializeField] private Button HighlightButton;
    [SerializeField] private Slider Part;
    // Start is called before the first frame update
    void Start()
    {
        UpdateData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void UpdateData()
    {
        Lenght.value = style.Lenght;
        Part.value = style.Part;
        ColorButton.image.color = style.color;
        HighlightButton.image.color = style.hightLight;
    }

}
