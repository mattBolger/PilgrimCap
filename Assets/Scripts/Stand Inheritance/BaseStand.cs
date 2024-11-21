using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BaseStand : TotalRevenue
{
    // The name of the stand
    public string standName;

    // The level of the stand
    public int standLevel;

    // The starting price of the stand
    public float standLevelUpPrice;

    // How much money the stand generates
    public float income;

    // The amount of time it takes the stand to generate income
    public float incomeCooldown;

    // The color of the panel of the stand
    public Color standColor;

    // The image of the stand
    public Sprite image;

    // The time of the game session
    public float gameTime;

    // Level up if the player has enough money
    public virtual void LevelUp()
    {
        if ((totalRevenue - standLevelUpPrice) >= 0)
        {
            totalRevenue -= standLevelUpPrice;
            standLevel += 1;
        }
    }

    // Add income if the alloted time has elapsed
    public virtual void AddIncome()
    {
        if ((gameTime - incomeCooldown) >= 0 && standLevel >= 1)
        {
            totalRevenue += income;
            gameTime = 0;
        }
    }

    // Keeps the time of the game
    public virtual void GameTime()
    {
        gameTime += Time.deltaTime;
    }

}
