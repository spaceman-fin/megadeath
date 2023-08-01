using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    
    public TMP_Text InstructionText;
    public GameObject ControlButton1;
    public GameObject ControlButton2;
    public GameObject ControlButton3;
    
    public void PlayHit()
    {
        SceneManager.LoadScene("fist");
    }

    public void ControlHit()
    {
        InstructionText.enabled = true;
        ControlButton1.SetActive(false);
        ControlButton2.SetActive(true);
        ControlButton3.SetActive(false);
    }

    public void BackHit()
    {
        InstructionText.enabled = false;
        ControlButton1.SetActive(true);
        ControlButton2.SetActive(false);
        ControlButton3.SetActive(true);
    }

    public void QuitHit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }


}
