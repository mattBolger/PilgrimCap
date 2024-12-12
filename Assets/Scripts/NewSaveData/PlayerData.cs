using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    // The total amount of money the player has
    public int totalRev;

    // Corn stand values
    public int cornLevel;
    public bool cornBought;

    // Fish stand values
    public int fishLevel;
    public bool fishBought;

    // Turkey stand values
    public int turkeyLevel;
    public bool turkeyBought;  
    
    // Potatoe stand values
    public int potatoeLevel;
    public bool potatoeBought;

    // Pumpkin stand values
    public int pumpkinLevel;
    public bool pumpkinBought;

    // Hat stand values
    public int hatLevel;
    public bool hatBought;

    // Cranberry stand values
    public int cranberryLevel;
    public bool cranberryBought;

    public PlayerData (Player player)
    {
        // Total rev
        totalRev = player.totRevenue;

        // Corn
        cornLevel = player.cornL;
        cornBought = player.cornB;

        // Fish
        fishLevel = player.fishL;
        fishBought = player.fishB;

        // Turkey
        turkeyLevel = player.turkeyL;
        turkeyBought = player.turkeyB;

        // Potatoe
        potatoeLevel = player.potatoL;
        potatoeBought = player.potatoB;

        // Pumpkin
        pumpkinLevel = player.pumpkinL;
        pumpkinBought = player.pumpkinB;

        // Hat
        hatLevel = player.hatL;
        hatBought = player.hatB;

        // Cranberry
        cranberryLevel = player.cranberryL;
        cranberryBought = player.cranberryB;

    }
}
