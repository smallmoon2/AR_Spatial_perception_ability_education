﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csParticle : MonoBehaviour
{
    public GameObject particle;

    void OnMouseDown()
    {
        GameObject p = Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(p, 3);
    } 

}
