using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class PilgAnim : MonoBehaviour
{
    public GameObject pilg;

    public Sprite pilgSprite;

    public float rotSpeed;

    bool canMoveClockwise;

    float gameTime;

    public float rotTime;

    bool firstTime;

    void Start()
    {
        canMoveClockwise = true;
        firstTime = true;

        pilg.GetComponent<Image>().sprite = pilgSprite;
    }

    // Call first time if it is the first time
    void FixedUpdate()
    {
        if (firstTime)
        {
            FirstDirectionUpdate();
        }
        DirectionUpdate();
        RotationUpdate();        
    }

    void Update()
    {
        Delay();
    }

    // The game time so the delay can be done
    void Delay()
    {
        gameTime += Time.deltaTime;
    }

    // The altered first time running logic
    void FirstDirectionUpdate()
    {
        if (gameTime > rotTime * .5 && canMoveClockwise == false)
        {
            canMoveClockwise = true;
            gameTime = 0;
            firstTime = false;
        }
        else if (gameTime > rotTime * .5 && canMoveClockwise == true)
        {
            canMoveClockwise = false;
            gameTime = 0;
            firstTime = false;
        }
    }

    // Set the direction of the pilgrim
    void DirectionUpdate()
    {
        if (gameTime > rotTime && canMoveClockwise == false)
        {
            canMoveClockwise = true;
            gameTime = 0;
        }
        else if (gameTime > rotTime && canMoveClockwise == true)
        {
            canMoveClockwise = false;
            gameTime = 0;
        }
    }

    // Rotate the pilgrim
    void RotationUpdate()
    {
        if (canMoveClockwise)
        {   
            pilg.transform.Rotate(0f, 0f, -rotSpeed);
        }
        else
        {
            pilg.transform.Rotate(0f, 0f, rotSpeed);
        }
    }
}
