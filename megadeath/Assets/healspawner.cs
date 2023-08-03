using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healspawner : MonoBehaviour
{

    public GameObject spawner1;
    
    public int heallolo;
    public Vector3 location;
    public GameObject healer;
    public bool canspawn = true;
    public GameObject thisspawn;
    public bool healed;
    //public toheal healthed;


    void Start()
    {
        //heallolo = Random.Range(1, 4);
        //thisspawn.GetComponent<healspawner>().healer = GameObject.Find("healingpack");
        location = spawner1.transform.position;
    }


    void Update()
    {
        //healed = toheal.givehealthed();
        /*
        heallolo = Random.Range(0, 4);
        
        if(heallolo == 1)
        {
            location = spawner1.transform.position;
        }
        if (heallolo == 2)
        {
            location = spawner2.transform.position;
        }
        if (heallolo == 3)
        {
            location = spawner3.transform.position;
        }

        if(canspawn)
        {
            Instantiate(healer, location, Quaternion.identity);
            canspawn = false;
        }
        */

        if(canspawn)
        {
            Instantiate(healer, location, Quaternion.identity);
            canspawn = false;
        }

        


    }


    public void changecan()
    {
        canspawn = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player")
        {
            Invoke("changecan", 7.5f); 
        }
    }

    




}
