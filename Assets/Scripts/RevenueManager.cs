using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevenueManager : MonoBehaviour
{
    // Array holding the stands
    [SerializeField] ResourceStand[] stands;

    // The time of the game
    float gameTime;

    // Update is called once per frame
    void Update()
    {
        
    }

    // Keeps the time passed since the game has started
    void Timer()
    {
        gameTime += Time.deltaTime;
    }
}
