using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class NewBehaviourScript : MonoBehaviour
{
    public VirtualButtonBehaviour vb;
    void Start()
    {
        vb.RegisterOnButtonPressed(OnBtnOn);
    }
    public void OnBtnOn(VirtualButtonBehaviour v)
    {
        Debug.Log("ลอฤกตส");
    }
}
