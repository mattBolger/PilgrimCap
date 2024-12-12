using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public bool paused = false;

    public AudioSource audioSource;

    public GameObject pauesMenu;

    void Start()
    {
        pauesMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            paused = !paused;

            if (paused)
            {
                audioSource.Play();
                Time.timeScale = 0;
                pauesMenu.SetActive(true);
            }
            else
            {
                audioSource.Play();
                Time.timeScale = 1f;
                pauesMenu.SetActive(false);
            }

        }

        
    }
}
