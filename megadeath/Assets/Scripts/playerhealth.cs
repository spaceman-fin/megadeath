using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
//goes on the PlayerObj, 
public class playerhealth : MonoBehaviour
{
    [Header("Basic Values")]
    public int health = 100;
    public static int score;
    [Header("GUI Elements")]
    public Slider healthBar;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        healthBar.minValue = 0f;
        healthBar.maxValue = health;
    }

    
    void Update()
    {
        healthBar.value = health;
        healthText.text = health.ToString();
        if (health <= 0)
            SceneManager.LoadScene("DeathScene");

        scoreText.text = playerhealth.score.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            health -= 10;
        }
    }
}
