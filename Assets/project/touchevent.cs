using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchevent : MonoBehaviour
{
    public GameObject draw1;
    public GameObject draw2;
    public GameObject draw3;

    public int value = 0;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư�� Ŭ������ ��
        {

            if (value == 1)
            {
                Debug.Log("Ȱ��ȭ�߽��ϴ�");
                draw1.SetActive(true);
                draw2.SetActive(false);
                draw3.SetActive(false);
            }

            if (value == 2)
            {
                Debug.Log("Ȱ��ȭ�߽��ϴ�");
                draw1.SetActive(false);
                draw2.SetActive(true);
                draw3.SetActive(false);
            }

            if (value == 3)
            {
                Debug.Log("Ȱ��ȭ�߽��ϴ�");
                draw1.SetActive(false);
                draw2.SetActive(false);
                draw3.SetActive(true);
            }

        }
    }
}
