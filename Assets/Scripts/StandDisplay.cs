using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class StandDisplay : MonoBehaviour
{
    // The reference to the stand
    public ResourceStand stand;

    // In-game UI references
    public TextMeshProUGUI nameText;
    public Image artworkImage;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI standLevelUpPrice;
    public TextMeshProUGUI income;
    int incomePerSec;

    // Start is called before the first frame update
    void Start()
    {
        // Set the starting values that will not change
        nameText.text = stand.standName;

        artworkImage.sprite = stand.image;

        this.GetComponent<Image>().color = stand.standColor;

        //This is for testing, ask jose about saved data
        stand.standLevel = 0;
    }

    void Update()
    {
        // Set the values and update them as they increment
        levelText.text = stand.standLevel.ToString();

        income.text = stand.income.ToString("C");

        standLevelUpPrice.text = (stand.standStartingPrice * Mathf.Pow(1.25f, stand.standLevel)).ToString("C");
    }
}
