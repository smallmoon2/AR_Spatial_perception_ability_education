using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickevent : MonoBehaviour
{
    public GameObject draw;
    public GameObject point;

    public GameObject final;


    public bool value;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư�� Ŭ������ ��
        {
            Debug.Log("��ġ�߽��ϴ�");
            GameObject newDraw = Instantiate(draw, point.transform.position, Quaternion.identity);
            Destroy(newDraw, 2f);

            if (value == true)
            {
                Debug.Log("Ȱ��ȭ�߽��ϴ�");
                final.SetActive(true);
            }
        }
    }
}
