using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class DeathScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreCount;
    private int endScore;
    private void Start()
    {
        endScore = playerhealth.score;
        scoreCount.text = "Your Score: " + endScore.ToString();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("startscene");
    }
}
