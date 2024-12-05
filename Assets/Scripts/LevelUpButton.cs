using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpButton : MonoBehaviour
{
    [SerializeField] TotalRevenue totalRevenue;
    // Takes the stand reference, adds 1 to the level and updates the income
    public void LevelUp(ResourceStand stand)
    {
        //if ((totalRevenue.totalMoney -= stand.standStartingPrice) >= 0)
        //{
        //    stand.standLevel += 1;

        //    stand.income = stand.standLevel * Mathf.Pow(1.125f, stand.standLevel);

        //    //totalRevenue.totalMoney -= stand.standStartingPrice;
        //}
    }
}
