using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyspawn : MonoBehaviour
{

    public int wave = 1;
    public int totalinwave = 1;
    public int currentinwave = 0;
    public GameObject enemy;
    public bool overwave = true;
    public bool canspawn = true;
    public int thiswave = 1;
    public bool inwave = true;
    public bool changein = true;
    public int x = 0;
    public bool canswitch = false;
    public int spawnloco;
    public Vector3 spawnpos;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject foundObjects;
    public bool displaytext = true;
    public TextMeshProUGUI currentwaveon;
    public Canvas textcanvas;
    

    //make it so when enemy dies, current in wave is subtracted by 1 or current wave is = to how many enemies r currently in the world 
    //var foundObjects = Object.FindObjectsOfType<YourComponentTypeHere>();
    //int count = foundObjects.Length;

    void Start()
    {
        spawnloco = Random.Range(1, 4);
        thiswave = currentinwave;
        if(spawnloco == 1)
        {
            spawnpos = spawn1.transform.position;
        }
        if (spawnloco == 2)
        {
            spawnpos = spawn2.transform.position;
        }
        if (spawnloco == 3)
        {
            spawnpos = spawn3.transform.position;
        }
    }


    void Update()
    {


        currentwaveon.text = "wave " + wave.ToString();
        //foundObjects = Object.FindObjectsOfType<>();
        //var foundObjects = 
        //currentinwave = foundObjects.Length();

        currentinwave = GameObject.FindGameObjectsWithTag("enemy in game").Length;

        if(displaytext)
        {
            textcanvas.enabled = true;
            Invoke("changedisplay", 1);

        }

        spawnloco = Random.Range(1, 4);
        if (spawnloco == 1)
        {
            spawnpos = spawn1.transform.position;
        }
        if (spawnloco == 2)
        {
            spawnpos = spawn2.transform.position;
        }
        if (spawnloco == 3)
        {
            spawnpos = spawn3.transform.position;
        }


        //if (Input.GetKeyDown(KeyCode.J))
        //{
            //Debug.Log("next");
            //wave++;
        //}
        //if (Input.GetKeyDown(KeyCode.L))
        //{
            //totalinwave -= 1;
        //}
        if (wave == 1)
        {

            totalinwave = 1;


        }
        if (wave == 2)
        {
            totalinwave = 3;
        }
        if (wave == 3)
        {
            totalinwave = 5;
        }
        if (wave == 4)
        {
            totalinwave = 7;
        }
        if (wave == 5)
        {
            totalinwave = 9;
        }
        if (wave > 5 && overwave)
        {
            overwave = false;
            totalinwave += 5;
        }

        if (canswitch)
        {
            wave++;
            overwave = true;
            //delay();
            currentinwave = 0;
            x = 0;
            canswitch = false;
            displaytext = true;
        }
        spawning();
        //if (Input.GetKeyDown(KeyCode.F))
        //{
            //currentinwave--;
       // }
    }

    public void spawning()
    {


        if (x < totalinwave && canspawn)
        {
            Invoke("tospawn", 1.5f);
            canspawn = false;
            //canspawn = false;
            //thiswave = currentinwave;
        }
        if (currentinwave == 0 && x == totalinwave)
        {
            canswitch = true;
        }


        //for(int i = 0; i <= totalinwave; i++)
        //{
        //if(canspawn)
        //{
        //Instantiate(enemy);
        //canspawn = false;
        //currentinwave++;
        //Invoke("delay", 1.5f);
        //Invoke("tospawn", 1.5f);
        //}

        //}




    }

    public void delay()
    {
        canspawn = true;
    }

    public void tospawn()
    {
        Instantiate(enemy, spawnpos, Quaternion.identity);
        currentinwave++;
        canspawn = true;
        x++;
    }

    public void changedisplay()
    {
        displaytext = false;
    }
}