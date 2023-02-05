using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuOpen : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.SetActive(true);
            Time.timeScale= 0f;
        }
    }
}
