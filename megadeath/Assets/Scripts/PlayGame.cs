using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
// goes on the start scene canvas, assign the correct functions to the buttons 
public class playgame : MonoBehaviour
{
    
    public TMP_Text instructiontext;
    public Button controlbutton;
    public GameObject controlbutton1;
    public GameObject controlbutton2;
    public GameObject controlbutton3;
   
    public void playhit()
    {
        SceneManager.LoadScene("fist");
        playerhealth.score = 0;
    }

    public void controlhit()
    {
        instructiontext.enabled = true;
        controlbutton1.SetActive(false);
        controlbutton2.SetActive(true);
        controlbutton3.SetActive(false);
    }

    public void backhit()
    {
        instructiontext.enabled = false;
        controlbutton1.SetActive(true);
        controlbutton2.SetActive(false);
        controlbutton3.SetActive(true);
    }

    public void quithit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }


}
