using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csGenerateMoon : MonoBehaviour
{

    public GameObject moon;
    void OnMouseDown()
    {
        GameObject p = Instantiate(moon, new Vector3(0,0,0), Quaternion.identity);
        p.transform.SetParent(transform, true); // local 좌표를 0.0,0으로 
        
    } 

}
