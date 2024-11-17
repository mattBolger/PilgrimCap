using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Stands", order = 1)]
public class ResourceStand : ScriptableObject
{
    // The name of the stand
    public string standName;

    // The starting level of the stand
    public int standLevel;

    // The starting price of the stand
    public float standStartingPrice;

    // How much money per _____ time
    public float income;

    // Time to make ____ amount of money
    public float incomePerSecond;

    // Color of the panel
    public Color standColor;

    // Img of the panel
    public Sprite image;
};
