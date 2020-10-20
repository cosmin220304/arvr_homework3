using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGrab : MonoBehaviour
{
    public Animator anim;
     
    public void toggle()
    {
        anim.SetTrigger("IsGrabbing");
    }  
}
