using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Total rev ref
    public TotalRevenue total;

    // total rev
    public int totRevenue;

    // Stand referneces
    public standCorn corn;
    public standFish fish;
    public standTurkey turkey;
    public standDeer deer;
    public standPotatoes potatoes;
    public standPumpkin pumpkin;
    public standHat hat;
    public standCranberry cranberry;

    // Stand levels
    public int cornL;
    public int fishL;
    public int turkeyL;
    public int deerL;
    public int potatoL;
    public int pumpkinL;
    public int hatL;
    public int cranberryL;

    // Stand is bought
    public bool cornB;
    public bool fishB;
    public bool turkeyB;
    public bool deerB;
    public bool potatoB;
    public bool pumpkinB;
    public bool hatB;
    public bool cranberryB;

    // Update is called once per frame
    void Update()
    {
        SetLevel();
        SetBought();
        SetRev();
    }

    void SetRev()
    {
        totRevenue = total.totalMoney;
    }

    void SetLevel()
    {
        cornL = corn.standLevel;
        fishL = fish.standLevel;
        turkeyL = turkey.standLevel;
        deerL = deer.standLevel;
        potatoL = potatoes.standLevel;
        pumpkinL = pumpkin.standLevel;
        hatL = hat.standLevel;
        cranberryL = cranberry.standLevel;
    }

    void SetBought()
    {
        cornB = corn.standBought;
        fishB = fish.standBought;
        turkeyB = turkey.standBought;
        deerB = deer.standBought;
        potatoB = potatoes.standBought;
        pumpkinB = pumpkin.standBought;
        hatB = hat.standBought;
        cranberryB = cranberry.standBought;
    }
}
