using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//goes on the PlayerObj, 
public class playerhealth : MonoBehaviour
{
    
    public int health = 100;
    public enemymovement gethealing;
    public bool healing = false;
    public GameObject theplayer;
    public bool healed = false;
    public int toheal = 0;
    public bool damaged = false;
    public hit fistheal;
    public bool hh;


    void Start()
    {
        theplayer.GetComponent<playerhealth>().gethealing = GameObject.FindObjectOfType<enemymovement>();
        theplayer.GetComponent<playerhealth>().fistheal = GameObject.FindObjectOfType<hit>();
    }

    
    void Update()
    {




        //hh = gethealing.hhh();

        //if(hh)
        //{
           //health = gethealing.thishealth();
           //hh = false;

        //}
        





        /*
        if (!healed)
        {
            hh = gethealing.hhh();
        }
        

        if(hh)
        {
            health += 10;
            healed = true;
            hh = false;
            theplayer.GetComponent<playerhealth>().gethealing = GameObject.FindObjectOfType<enemymovement>();
        }
        

        //if(!hh)
        //{
            //toheal = gethealing.thishealth();
        //}
        

        //if(toheal == 10)
        //{
          //  health -= toheal;
            //toheal = 0;
            //damaged = true;
            
           // Invoke("healdelay", 0.01f);
        //}
        
        /*
        if(!healed)
        {
            healed = fistheal.givehealed();
        }
        

        if(healed)
        {
            health += 10;
            healed = false;
        }
        */



        if (health > 100)
        {
            health = 100;
        }

        /*
        healing = gethealing.healthing();

        if(healing && !healed)
        {
            healed = true;
        }

        if(healed)
        {
            toheal += 1;
            healed = false;
        }

        if(toheal > 0 && toheal % 2 == 0)
        {
            health += 10;
        }

                
            
        

        if(!damaged)
        {
            health = gethealing.thishealth();
        }
        */








    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            health -= 20;

        }
        
    }

    

    public int heal()
    {
       return health;
    }

    public void healdelay()
    {
        damaged = false;
    }
}
