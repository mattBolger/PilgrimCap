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

    void Delay()
    {
        gameTime += Time.deltaTime;
    }

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

    void RotationUpdate()
    {
        if (canMoveClockwise)
        {
            Debug.Log(pilg.transform.rotation.eulerAngles.z);
            
            pilg.transform.Rotate(0f, 0f, -rotSpeed);
        }
        else
        {
            pilg.transform.Rotate(0f, 0f, rotSpeed);
        }
    }
}
