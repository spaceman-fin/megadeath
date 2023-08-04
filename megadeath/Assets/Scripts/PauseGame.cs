using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject PausePanel;
    private bool isPaused;
    public KeyCode PauseKey = KeyCode.Escape;
    

    private void Start()
    {
        PausePanel.SetActive(false);
        isPaused = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(PauseKey) && !isPaused)
            Pause();
    }

    private void Pause()
    {
        isPaused = true;
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Resume()
    {
        isPaused = false;
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public bool getpaused()
    {
        return isPaused;
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("startscene");
    }
}
