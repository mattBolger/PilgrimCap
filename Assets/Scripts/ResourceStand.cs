using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Stands", order = 1)]
public class ResourceStand : ScriptableObject
{
    public string standName;

    public int standLevel;

    public float standStartingPrice;

    public Color standColor;

    public Sprite image;
};
