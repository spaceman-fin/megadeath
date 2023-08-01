using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//goes on fist
public class hit : MonoBehaviour
{

    public GameObject arm;
    public float dashspeed = 1;
    public Rigidbody fist;
    public GameObject target;
    //public Vector3 movefist;
    public GameObject playercamera;
    public Rigidbody playermove;

    public bool ispunching;
    public animationforpunch punch;
    
    public GameObject playerdasher;

    void Start()
    {
        //directiondash = new Vector3(playerdasher.transform.rotation.x, playerdasher.transform.rotation.y, playerdasher.transform.rotation.z);
        //directiondash = playerdasher.transform.localEulerAngles;
        
    }

    
    void Update()
    {

        //directiondash = new Vector3(playerdasher.transform.rotation.x, playerdasher.transform.rotation.y, playerdasher.transform.rotation.z);
        //directiondash = playerdasher.transform.localEulerAngles;
        playerdash();
        ispunching = punch.punch();
        
        
    }

    
    public void attack()
    {
        
    }

    public void playerdash()
    {
        if(Input.GetMouseButtonDown(0) && !ispunching)
        {
            //Debug.Log("movedplayer");
            Invoke("delay", 0.25f);
            playermove.AddForce(playerdasher.transform.forward * 70f, ForceMode.Impulse);
            //playerdasher.transform.forward = transform.forward;
        }
    }

    public void delay()
    {
        //playermove.AddForce(0, 0, 60, ForceMode.Impulse);
        Debug.Log("dashing");
        //playermove.AddRelativeForce(directiondash, ForceMode.Impulse);
        
    }
    
    
}
