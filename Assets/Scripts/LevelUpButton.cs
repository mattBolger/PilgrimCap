using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpButton : MonoBehaviour
{
    // Takes the stand reference, adds 1 to the level and updates the income
    public void levelUp(ResourceStand stand)
    {
        stand.standLevel += 1;

        stand.income = stand.standLevel * Mathf.Pow(2.25f, stand.standLevel);
    }

}
