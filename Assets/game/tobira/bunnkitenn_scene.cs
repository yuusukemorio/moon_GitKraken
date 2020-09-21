using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bunnkitenn_scene : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);
        Debug.Log("hureta");

        if (collision.gameObject.name == "iv")
        {
            ChangeScene();
            Debug.Log("OK");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Debug.Log("hureta");

        if (other.gameObject.name == "iv")
        {
            ChangeScene();
            Debug.Log("OK");
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Hacking");
    }
}

