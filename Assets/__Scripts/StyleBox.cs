using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Style", order = 1)]
public class StyleBox : ScriptableObject
{
    public float Lenght;
    public Color color;
    public Color hightLight;
    public float Part;
}
