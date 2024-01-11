using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class csEvent : MonoBehaviour
{
    public GameObject preGroundPlane;
    public GameObject preObj;
    public GameObject[] preObjs;

    bool flagAutoHitTest = false;

    void AddObj(int index, float scale)
    {
        print("더하기");
        GameObject plane = Instantiate(preGroundPlane);
        GameObject obj = Instantiate(preObjs[index], new Vector3(0, 0, 0), Quaternion.identity);
        obj.transform.SetParent(plane.transform, true);
        obj.transform.localScale = new Vector3(scale, scale, scale);
        GetComponent<ContentPositioningBehaviour>().AnchorStage = plane.GetComponent<AnchorBehaviour>();
        flagAutoHitTest = false;
    }



    public void AutomaticHitTest(HitTestResult result)
    {
        print("바닥 검출시 ");
    }

    public void InteractiveHitTest(HitTestResult result)
    {
        print("클릭할때");
    }


    public void ContentPlaced(GameObject obj)
    {
        print("오브젝트가 생성될때");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject plane = Instantiate(preGroundPlane);
            GameObject obj = Instantiate(preObj, new Vector3(0, 0, 0), Quaternion.identity);
            obj.transform.SetParent(plane.transform, true);
            obj.transform.localScale = new Vector3(0.04f, 0.04f, 0.04f);
            GetComponent<ContentPositioningBehaviour>().AnchorStage = plane.GetComponent<AnchorBehaviour>();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            GetComponent<ContentPositioningBehaviour>().AnchorStage.transform.GetChild(0).Translate(0.005f, 0, 0, GetComponent<ContentPositioningBehaviour>().AnchorStage.transform);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            GetComponent<ContentPositioningBehaviour>().AnchorStage.transform.GetChild(0).Translate(-0.005f, 0, 0, GetComponent<ContentPositioningBehaviour>().AnchorStage.transform);
        if (Input.GetKeyDown(KeyCode.UpArrow))
            GetComponent<ContentPositioningBehaviour>().AnchorStage.transform.GetChild(0).Translate(0, 0, -0.005f, GetComponent<ContentPositioningBehaviour>().AnchorStage.transform);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            GetComponent<ContentPositioningBehaviour>().AnchorStage.transform.GetChild(0).Translate(0, 0, 0.005f , GetComponent<ContentPositioningBehaviour>().AnchorStage.transform);




    }

    private void OnGUI()
    {
        GUIStyle styButton = new GUIStyle(GUI.skin.button);
        styButton.fontSize = 15;

        if (GUI.Button(new Rect(10, 10, 100, 50), "의자", styButton))
            AddObj(0, 0.04f);

        if (GUI.Button(new Rect(110, 10, 100, 50), "침대", styButton))
            AddObj(1, 0.04f);

        if (GUI.Button(new Rect(210, 10, 100, 50), "테이블", styButton))
            AddObj(2, 0.04f);

        if (GUI.Button(new Rect(10, 70, 100, 50), "회전", styButton))
            GetComponent<ContentPositioningBehaviour>().AnchorStage.transform.GetChild(0).Rotate(0, 20, 0);

        if (GUI.Button(new Rect(110, 70, 100, 50), "+", styButton))
            GetComponent<ContentPositioningBehaviour>().AnchorStage.transform.GetChild(0).localScale *= 1.1f;

        if (GUI.Button(new Rect(210, 70, 100, 50), "-", styButton))
            GetComponent<ContentPositioningBehaviour>().AnchorStage.transform.GetChild(0).localScale *= 0.9f;


        if (GUI.Button(new Rect(310, 70, 100, 50), "삭제", styButton))
            Destroy(GetComponent<ContentPositioningBehaviour>().AnchorStage);
        

    }


    public void HitTest(HitTestResult result)
    {
        if (flagAutoHitTest == true)
            GetComponent<ContentPositioningBehaviour>().PositionContentAtPlaneAnchor(result);
        flagAutoHitTest = false;
    }


}
