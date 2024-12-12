using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject mainMenu;
    [SerializeField]
    GameObject howToPlay;

    public AudioSource audioSource;

    void Start()
    {
        mainMenu.SetActive(true);
        howToPlay.SetActive(false);
    }

    void PlayAudio()
    {
        audioSource.Play();
    }

    public void PlayGame()
    {
        Invoke(nameof(PlayAudio), 1);
        SceneManager.LoadScene("Level");
    }

    public void HowToPlay()
    {
        audioSource.Play();
        mainMenu.SetActive(false);
        howToPlay.SetActive(true);
    }

    public void OpenMainMenu()
    {
        audioSource.Play();
        howToPlay.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void QuitGame()
    {
        audioSource.Play();
        Application.Quit();
    }
}
