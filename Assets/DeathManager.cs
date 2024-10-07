using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{

    public GameObject deathScreenCanvas; // reference to the death screen canvas

    // show the death screen
    public void ShowDeathScreen()
    {

        //activate the death screen ui
        deathScreenCanvas.SetActive(true);

        //Pause the game
        Time.timeScale = 1f;
    }

    //restart the game (called by a button)

    public void RestartGame()
    {
        //Reset time and reload current scene
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Quit the game called by  a button

    public void QuitGame()
    {
        //Reset time scale and quit the application
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}   