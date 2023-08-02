using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//goes on the PlayerObj, 
public class playerhealth : MonoBehaviour
{
    
    public int health = 100;
    public Slider healthBar;
    public TextMeshProUGUI healthText;

    void Start()
    {
        healthBar.minValue = 0f;
        healthBar.maxValue = health;
    }

    
    void Update()
    {
        healthBar.value = health;
        healthText.text = health.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            health -= 20;
        }
    }
}
