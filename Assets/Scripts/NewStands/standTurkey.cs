using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class standTurkey : MonoBehaviour
{
    // The name of the stand
    public string standName = "Turkey Stand";

    // Is the stand bought
    public bool standBought = false;

    // The level of the stand
    public int standLevel = 0;

    // The price to level up the stand
    public int levelUpPrice = 100;

    // The amount of money the stand brings in
    public int income = 0;

    // How long it takes the stand to bring in money
    public float cooldown = 10;

    // The color of the stand
    public Color standColor;

    // The image of the stand
    public Sprite image;

    // The time of the game
    float gameTime;

    // In-game UI references
    public TextMeshProUGUI nameText;
    public Image artworkImage;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI standLevelUpPrice;
    public TextMeshProUGUI incomeText;

    // Reference to the total revenue
    [SerializeField] TotalRevenue totalRevenue;

    void Start()
    {
        nameText.text = standName;
        artworkImage.sprite = image;
        this.GetComponent<Image>().color = standColor;
    }

    // Runs every frame
    void Update()
    {
        GameTimer();
        TextUpdate();
        IncomeUpdate();
        Income();
    }

    // Level up button that all stands will inherit
    public void LevelUpButton()
    {
        if (standBought != true && totalRevenue.totalMoney >= levelUpPrice) 
        {
            totalRevenue.totalMoney -= levelUpPrice;
            standBought = true;
            standLevel += 1;
            
        }
        else if (totalRevenue.totalMoney >= levelUpPrice)
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

    public void TextUpdate()
    {
        levelText.text = standLevel.ToString();

        incomeText.text = income.ToString("C");

        standLevelUpPrice.text = levelUpPrice.ToString("C");
    }

    public void IncomeUpdate()
    {
        income = standLevel * 3;
    }    
}
