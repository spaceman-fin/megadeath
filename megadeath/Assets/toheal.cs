using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toheal : MonoBehaviour
{

    public GameObject healer;
    public bool didheal = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            //didheal = true;
            Debug.Log("healed");
            Destroy(healer);
            //Invoke("canchange", 10);
        }
    }

    public bool givehealthed()
    {
        return didheal;
    }
}
