using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camera_angle : MonoBehaviour
{
    //camera_collision CCscript;
    //GameObject camera_hanntei;
    public camera_collision cameraC;
    string CCscript;

    void Start()
    {
        //camera_hanntei = GameObject.Find("camera_hanntei");
        //CCscript = camera_hanntei.GetComponent<camera_collision>();

        CinemachineVirtualCamera CVcamera = this.gameObject.GetComponent<CinemachineVirtualCamera>();

        CCscript = cameraC.nani_hureta;
    }


    void Update()
    {
        if (CCscript == "hall_in")
        {
            //CVcamera.Priority = 40;
            Debug.Log("Hello");
        }
        if (CCscript == "hall_out")
        {
            Debug.Log("HHello");
        }

        if (CCscript == "tuuro_in")
        {
            Debug.Log("HHHello");
        }
        if (CCscript == "tuuro_out")
        {
            Debug.Log("HHHHello");
        }
    }
}