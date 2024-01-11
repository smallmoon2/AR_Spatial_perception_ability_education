using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csAnimation : MonoBehaviour
{
    bool state = false;
    void OnMouseDown()
    {
        if (state == false)
        {
            state = true;
            GetComponent<Animator>().SetTrigger("Run");
        }
        else
        {
            state = false;
            GetComponent<Animator>().SetTrigger("Idle");
        }
    } 
}
