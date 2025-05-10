using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{

    public GameObject YouSurePanel;

    public void Start()
    {
        YouSurePanel.SetActive(false);
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void OnClickExit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif

    }

    public void OnSureExit()
    {
        YouSurePanel.SetActive(true);
    }

    public void OnCloseSure()
    {
        YouSurePanel.SetActive(false);
    }

}
