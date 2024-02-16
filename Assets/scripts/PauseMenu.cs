using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool pauseGame;
    public GameObject pauseGameMenu;

    public KeyCode pauseKey = KeyCode.Escape;

    public AudioListener audioListener;

    private void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            if (pauseGame) { Resume(); } else { Pause(); }
        }
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1.0f;
        pauseGame = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        audioListener.enabled = true;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0.0f;
        pauseGame = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        audioListener.enabled = false;
    }

    public void LoadMenu()
    {
        print("Exit to menu botton pressed");
        Time.timeScale = 1.0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        audioListener.enabled = true;
        Resume();
    }

}
