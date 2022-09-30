using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    GameObject SystemCanvas;

    private void Start() {
        SystemCanvas = GameObject.Find("SystemCanvas");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    public void Resume(){
        SystemCanvas.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void MainMenu(){
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame(){
        Application.Quit();
    }

    void Pause(){
        
        SystemCanvas.SetActive(false);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
