using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bunnkitenn_scene : MonoBehaviour
{

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

