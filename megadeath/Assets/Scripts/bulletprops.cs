using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletprops : MonoBehaviour
{

    //goes on bullet prefab

    public Rigidbody rb;
    public GameObject player;
    public Vector3 playerpos;
    public Vector3 bulletpos;
    public GameObject bullet;
    public int x = 1;
    public bool attackingplayer = true;
    public Vector3 lookdirection;
    public Quaternion rotate;
    public bool isinrange = true;
    public enemymovement getifinrange;
    public bool canfollow = true;
    public Vector3 up = new Vector3(0, 0.5f, 0);

    void Start()
    {
        //player = GameObject.FindWithTag("player in game");
        //getifinrange.GetComponent<enemymovement>(). = ;

        //bullet.GetComponent<bulletprops>().getifinrange = 

        // give the bullet the script for the enemy in the game, not prefab
        
    }

    
    void Update()
    {
        isinrange = getifinrange.bullrange(); 
        if(!isinrange)
        {
            x = 1;
        }

        if(x == 1 && isinrange && canfollow)
        {
            playerpos = player.transform.position;
            //playerpos = transform.TransformPoint(playerpos);
            lookdirection = player.transform.position + up - bullet.transform.position;
            rotate = Quaternion.LookRotation(lookdirection);
            bullet.transform.rotation = rotate;
            x = 0;
        }
        //playerpos = player.transform.position;
        bulletpos = bullet.transform.position;
        if(attackingplayer)
        {
            movetoward();
        }
        
        else if(!attackingplayer)
        {
            keepmoving();
        }
        
        ifnohit();

    }

    public void movetoward()
    {
        bullet.transform.position = Vector3.MoveTowards(bulletpos, playerpos + up, 0.2f);
    }

    public void OnTriggerEnter(Collider other)
    {
        //if(other.tag == "player in game")
        //{
        if(other.tag != "healpack" || other.tag != "enemy in game")
        {
            Destroy(bullet);
        }
            
            //Debug.Log("player hit");
        //}


    }
    
    public void ifnohit()
    {
        if(Vector3.Distance(bulletpos, playerpos + up)  == 0)
        {
            attackingplayer = false;
            keepmoving();
            //Debug.Log("done moving");
        }
    }

    public void keepmoving()
    {
        rb.AddForce(bullet.transform.forward * 0.2f, ForceMode.VelocityChange);
        canfollow = false;
    }
    
}
