using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cinema_angle : MonoBehaviour
{

    CinemachineVirtualCamera vcamera ;
    string hall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "hall_out")
        {
            Debug.Log("HallOut");
        }
    }
}
