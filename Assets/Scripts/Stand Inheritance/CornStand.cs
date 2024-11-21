using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CornStand : BaseStand
{
    // The data container for the stand
    public ResourceStand stand;

    // In-game UI references
    public TextMeshProUGUI nameText;
    public Image artworkImage;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI standLevelUpPriceText;
    public TextMeshProUGUI incomeText;


    // Set references at the start
    public void Start()
    {
        SetReferences();
        SetUI();        
    }

    // Update the game time and the income
    void Update()
    {
        GameTime();
        AddIncome();
        UpdateUI();
    }

    void SetReferences()
    {
        standName = stand.standName;
        standLevel = stand.standLevel;
        standLevelUpPrice = stand.standStartingPrice;
        standColor = stand.standColor;
        income = stand.income;
        incomeCooldown = stand.incomePerSecond;
        image = stand.image;
    }

    void SetUI()
    {
        // Set UI values
        nameText.text = standName;
        artworkImage.sprite = image;
        this.GetComponent<Image>().color = standColor;
    }

    void UpdateUI()
    {
        levelText.text = standLevel.ToString();

        incomeText.text = income.ToString("C");

        standLevelUpPriceText.text = standLevelUpPrice.ToString("C");
    }

}
