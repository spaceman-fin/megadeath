using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationforpunch : MonoBehaviour
{


    public Animator punchanimation;
    public BoxCollider fisthitbox;
    public bool canpunch = true;
    public bool punchcd = true;
    public bool ispunching = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        attackhit();
    }

    public void attackhit()
    {
        if(Input.GetMouseButtonDown(0) && canpunch && punchcd)
        {
            punchanimation.SetTrigger("punch");
            fisthitbox.enabled = true;
            canpunch = false;
            Invoke("resethit", 0.4f);
            punchcd = false;
            ispunching = true;
            Invoke("changecd", 1);
        }
    }

    public void resethit()
    {
        fisthitbox.enabled = false;
        canpunch = true;

    }

    public void delayhit()
    {
        fisthitbox.enabled = true;
        
    }
    public void changecd()
    {
        punchcd = true;
        ispunching = false;
    }

    public bool punch()
    {
        return ispunching;
    }
}
