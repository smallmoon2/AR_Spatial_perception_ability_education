using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public Mesh[] meshes;

    public GameObject[] asd;
    public int[] ass;
    private int i = 0;


    void OnMouseDown()
    {

        GetComponent<MeshFilter>().sharedMesh = meshes[++i % meshes.Length];

    }


}
