using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickevent2 : MonoBehaviour
{
    public GameObject draw;
    public GameObject point;

    public GameObject final;
    public GameObject[] final2 = new GameObject[6] ;

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
                for (int i = 0; i < 3; i++)
                {
                    final2[i].SetActive(false);
                }

                for ( int i = 3; i < 6; i++)
                {
                    final2[i].SetActive(true);
                }

            }

        }
    }
}
