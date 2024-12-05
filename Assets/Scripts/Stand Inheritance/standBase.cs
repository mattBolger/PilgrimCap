using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standBase
{
    // The name of the stand
    public string standName;

    // Is the stand bought
    public bool standBought;
    
    // The level of the stand
    public int standLevel;

    // The price to level up the stand
    public int levelUpPrice;

    // The amount of money the stand brings in
    public int income;

    // How long it takes the stand to bring in money
    public float cooldown;

    // The color of the stand
    public Color standColor;

    // The image of the stand
    public Sprite image;

    // The time of the game
    public float gameTime;

    // Reference to the total revenue
    [SerializeField] TotalRevenue totalRevenue;

    // Level up button that all stands will inherit
    public void LevelUpButton()
    {
        if (totalRevenue.totalMoney >= levelUpPrice)
        {
            totalRevenue.totalMoney -= levelUpPrice;
            standLevel += 1;
        }
    }

    // Adds income when the cooldown has been reached
    public void Income()
    {
        if (gameTime >= cooldown)
        {
            gameTime = 0;

            totalRevenue.totalMoney += income;
        }
    }

    // counts the game time
    public void GameTimer()
    {
        gameTime += Time.deltaTime;
    }
}