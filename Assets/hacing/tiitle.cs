using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiitle : MonoBehaviour

{
    float count = 0.0f;
    float timeLimit = 2.5f;


    // Start is called before the first frame update
    void Start()
    {

        //CanvasGroup CG = this.GetComponent<CanvasGroup>();

    }
    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;

        if (count >= timeLimit)
        {
            //CG.alpha = 0;
            this.GetComponent<CanvasGroup>().alpha = 0;
        }
    }
}
