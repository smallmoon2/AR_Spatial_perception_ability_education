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
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼을 클릭했을 때
        {
            Debug.Log("터치했습니다");
            GameObject newDraw = Instantiate(draw, point.transform.position, Quaternion.identity);
            Destroy(newDraw, 2f);

            if (value == true)
            {
                Debug.Log("활성화했습니다");
                final.SetActive(true);
            }
        }
    }
}
