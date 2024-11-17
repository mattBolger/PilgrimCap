using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalRevenue : MonoBehaviour
{
    // The total money owned by the player
    public float totalRevenue;

    // In-game UI reference
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    // Update is called once per frame
    void Update()
    {

        // Functions that always run
        UpdateTotalRevenue();
    }

    // Sends the total revenue to a string to be displayed
    void UpdateTotalRevenue()
    {
        textMeshProUGUI.text = totalRevenue.ToString();
    }
}
