using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatewithcam : MonoBehaviour
{

    public GameObject player;
    public GameObject arm;

    void Start()
    {
        
    }

    
    void Update()
    {
        rotatewithplayer();
    }

    public void rotatewithplayer()
    {
        arm.transform.rotation = player.transform.rotation;
    }

}
