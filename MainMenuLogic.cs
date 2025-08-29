using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    private GameObject mainMenu;
    private GameObject creditsMenu;
    private GameObject loading;

    public AudioSource buttonSound;

    void Start()
    {
        mainMenu = GameObject.Find("MainMenuCanvas");
        creditsMenu = GameObject.Find("CreditsCanvas");
        loading = GameObject.Find("LoadingCanvas");

        mainMenu.GetComponent<Canvas>().enabled = true;
        creditsMenu.GetComponent<Canvas>().enabled = false;
        loading.GetComponent<Canvas>().enabled = false;
    }

    public void StartButton()
    {
        loading.GetComponent<Canvas>().enabled = true;
        mainMenu.GetComponent<Canvas>().enabled = false;
        buttonSound.Play();
        SceneManager.LoadScene("Cutscene");
    }

    public void CreditsButton()
    {
        buttonSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = false;
        creditsMenu.GetComponent<Canvas>().enabled = true;
    }

    public void ExitGameButton()
    {
        buttonSound.Play();
        Application.Quit();
    }

        public void ReturnToMainMenu()
    {
        buttonSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = true;
        creditsMenu.GetComponent<Canvas>().enabled = false;
    }
}
