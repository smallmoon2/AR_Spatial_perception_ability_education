using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateobject : MonoBehaviour
{
    private bool isRotating = false;
    private float rotationSpeed = 1.0f;

    private void OnMouseDrag()

    {

        Debug.Log("Å¬¸¯");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * rotationSpeed * -mouseX, Space.World);
        transform.Rotate(Vector3.right * rotationSpeed * mouseY, Space.World);


    }



}