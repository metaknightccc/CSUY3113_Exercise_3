using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void BackToLobby(){
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
