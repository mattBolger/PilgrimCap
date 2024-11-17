using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevenueManager : MonoBehaviour
{
    // Array holding the stands
    [SerializeField] ResourceStand[] stands;

    // Reference to the total rev
    [SerializeField] TotalRevenue totRev;

    // The time of the game
    float gameTime;

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Timer();
        Income();
    }

    // Keeps the time passed since the game has started
    void Timer()
    {
        gameTime += Time.deltaTime;

    }

    // Checks to see if the stand can generate income
    void Income()
    {
        // Iterate through each stand
        for (int i = 0; i < stands.Length; i++)
        {
            Debug.Log((gameTime % stands[i].incomePerSecond) * 100.0f * .01f);

            // if the remainder is 0 add money (float math might not work)
            if (Mathf.Round((gameTime % stands[i].incomePerSecond) * 10.0f) * .1f == 0 && gameTime > 0)
            {
                totRev.totalRevenue += stands[i].income;
            }
        }
    }
}
