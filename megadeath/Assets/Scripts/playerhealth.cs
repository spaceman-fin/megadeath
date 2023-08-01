using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//goes on the PlayerObj, 
public class playerhealth : MonoBehaviour
{
    
    public int health = 100;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            health -= 20;
        }
    }
}
