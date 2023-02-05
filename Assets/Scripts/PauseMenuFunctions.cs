using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuFunctions : MonoBehaviour
{
    [SerializeField] GameObject canvas;

    public void closeClick()
    {
        canvas.SetActive(false);
    }

    public void resumeGame()
    {
        closeClick();
        Time.timeScale = 1f;
    }

    public void quitGame() 
    {
        Application.Quit();    
    }

    public void openMainMenu() 
    {
        SceneManager.LoadScene(0);
    }

}
