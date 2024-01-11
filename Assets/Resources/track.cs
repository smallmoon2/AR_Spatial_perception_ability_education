using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

using UnityEngine;

public class track : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTracked()
    {
        Debug.Log("----->tracked");
    }

    public void OnLost()
    {
        Debug.Log("------->lost");
    }

    public void OnTrackedvideo()
    {
        GameObject obj = GameObject.Find("Quad");


        obj.GetComponent<VideoPlayer>().Play();
    }
    public void OnLostvideo()
    {
        GameObject obj = GameObject.Find("Quad");


        obj.GetComponent<VideoPlayer>().Pause();
    }

}
