using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// goes on the enemy/enemyingame
public class movewhenhit : MonoBehaviour
{
    public Rigidbody rb;
    public float distancex;
    public GameObject armattack;
    public GameObject enemy;
    public int flyspeed = 100;
    public float distancey;
    public float distancez;

    void Start()
    {
        enemy.GetComponent<movewhenhit>().armattack = GameObject.FindGameObjectWithTag("fist");
    }

    
    void Update()
    {
        getdistance();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "fist")
        {
            
            rb.velocity += new Vector3(distancex, 3.5f, distancez) * flyspeed;










        }
    }

    public void getdistance()
    {
        distancex = (enemy.transform.position.x - armattack.transform.position.x) * 2.5f;
        distancey = (enemy.transform.position.y - armattack.transform.position.y) * 15;
        distancez = (enemy.transform.position.z - armattack.transform.position.z) * 2.5f;
    }

    
}
