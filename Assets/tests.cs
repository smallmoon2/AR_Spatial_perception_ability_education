using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tests : MonoBehaviour
{
    public int HP;



    private void OnTriggerEnter(Collider other)
    {
        if (HP < other.gameObject.GetComponent<tests>().HP)
        {
            GetComponent<Animator>().SetTrigger("LOSS");
        }
        else
        {
            GetComponent<Animator>().SetTrigger("WIN");
        }
    }


}
