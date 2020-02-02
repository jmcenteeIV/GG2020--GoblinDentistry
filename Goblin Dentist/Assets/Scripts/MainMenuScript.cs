using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void QuitGame ()
    {
        Debug.Log("The user has quit the game!");
        Application.Quit();
    }
}
