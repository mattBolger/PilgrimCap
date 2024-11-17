using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpButton : MonoBehaviour
{
    public void levelUp(ResourceStand stand)
    {
        stand.standLevel += 1;

        stand.income = stand.standLevel * Mathf.Pow(2.25f, stand.standLevel);
    }

}
