using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{

    public GameObject spawner;
    public GameObject bullet;
    public GameObject player;
    public bool isrange;
    public float distance;
    public bool firedelay = true;
    public GameObject ingamebullet;
    public int enemyhealth = 2;
    public GameObject realenemy;


    void Start()
    {

        realenemy.GetComponent<enemymovement>().player = GameObject.Find("realplayer");

    }

    
    void Update()
    {
        inrange();
        fire();
        enemydeath();
    }


    public void fire()
    {
        if(isrange && firedelay)
        {
            spawnbull();
            Invoke("changefire", 2);
        }
        
    }

    public void delayfire()
    {

    }
    
    public void moveto()
    {

    }

    public void inrange()
    {
        distance = Vector3.Distance(spawner.transform.position, player.transform.position);
        if(distance <= 11)
        {
            isrange = true;
        }
        else if(distance > 11)
        {
            isrange = false;
        }
    }

    public void spawnbull()
    {
        ingamebullet = Instantiate(bullet, spawner.transform.position, Quaternion.identity);
        ingamebullet.GetComponent<bulletprops>().player = GameObject.Find("realplayer");
        ingamebullet.GetComponent<bulletprops>().getifinrange = GameObject.FindObjectOfType<enemymovement>();
        firedelay = false;
    }

    public void changefire()
    {
        firedelay = true;
    }

    public bool bullrange()
    {
        return isrange;
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player in game")
        {
            enemyhealth--;
        }
    }

    public void enemydeath()
    {
        if(enemyhealth == 0)
        {
            Destroy(realenemy);

        }
    }


}
