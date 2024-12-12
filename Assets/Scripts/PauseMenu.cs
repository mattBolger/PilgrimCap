using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public PlayerControls playerControls;

    public AudioSource audioSource;

    public void Resume()
    {
        Time.timeScale = 1f;
        playerControls.paused = false;
        pauseMenu.SetActive(false);
        audioSource.Play();
    }

    public void ToMainMenu()
    {
        Time.timeScale = 1f;
        playerControls.paused = false;
        audioSource.Play();
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        audioSource.Play();
        Application.Quit();
    }

    public void PlayAudio()
    {
        audioSource.Play();
    }
}
