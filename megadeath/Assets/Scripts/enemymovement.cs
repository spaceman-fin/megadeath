using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//goes on enemy, re name the enemy to enemyingame if you drag the enemy from a prefab

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
    public Vector3 enemydirection;
    public Quaternion enemyrotate;
    public Vector3 enemyloco;
    public Vector3 playerloco;
//<<<<<<< HEAD
//<<<<<<< HEAD
    public bool cangethit = true;
    public BoxCollider enemyhitbox;
    public bool healing = false;
    public playerhealth killheal;
    public int enemplayerhealth = 100;
    public bool h = true;
    public bool ifpaused;
    public PauseGame pauser;
//=======
    private playerhealth ph;
    //>>>>>>> b9c321fb79f1c7e30ea03dd8e1263425a0a70738
    //=======
    //>>>>>>> d863e28232c699476552e3f1fee5bd36c98069f4

    private void Awake()
    {
        realenemy.GetComponent<enemymovement>().player = GameObject.Find("realplayer");
    }

    void Start()
    {
        realenemy.GetComponent<enemymovement>().pauser = FindObjectOfType<PauseGame>();
        ifpaused = pauser.getpaused();
        enemydirection = player.transform.position - realenemy.transform.position;
        enemyrotate = Quaternion.LookRotation(enemydirection);
        realenemy.transform.rotation = enemyrotate;
        realenemy.GetComponent<enemymovement>().player = GameObject.Find("realplayer");
//<<<<<<< HEAD
//<<<<<<< HEAD
        //realenemy.GetComponent<enemymovement>().killheal = GameObject.FindObjectOfType<playerhealth>();
        
//=======
//>>>>>>> b9c321fb79f1c7e30ea03dd8e1263425a0a70738
//=======
//>>>>>>> d863e28232c699476552e3f1fee5bd36c98069f4
    }

    
    void Update()
    {
        ifpaused = pauser.getpaused();
        realenemy.GetComponent<enemymovement>().player = GameObject.Find("realplayer");
        enemydirection = new Vector3(player.transform.position.x - realenemy.transform.position.x, 0f, player.transform.position.z - realenemy.transform.position.z);
        enemyrotate = Quaternion.LookRotation(enemydirection);
        realenemy.transform.rotation = enemyrotate;
        enemyloco = realenemy.transform.position;
        playerloco = player.transform.position;

        if(!ifpaused)
        {
            realenemy.transform.position = Vector3.MoveTowards(enemyloco, playerloco, 0.01f);
        }
        

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
        if(other.tag == "fist" && h)
        {
            enemyhealth--;
            h = false;
            Invoke("changeer", 1);
        }
    }

    public void enemydeath()
    {
        if(enemyhealth <= 0)
        {
            Destroy(realenemy);
//<<<<<<< HEAD
//<<<<<<< HEAD
            //cangethit = false;
            //Invoke("changecanget", 1);

//=======
            playerhealth.score += 100;
//>>>>>>> b9c321fb79f1c7e30ea03dd8e1263425a0a70738
//=======
            //playerhealth.score += 100;
//>>>>>>> d863e28232c699476552e3f1fee5bd36c98069f4
        }
    }
<<<<<<< HEAD

    public void changeer()
    {
        h = true;
    }


=======
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "DamageTile")
            enemyhealth = 0;
    }
>>>>>>> 7c31ed0a410f4161dc9693c509f2261dcae35061
}
