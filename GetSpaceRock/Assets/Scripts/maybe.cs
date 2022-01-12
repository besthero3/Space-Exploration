using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maybe : MonoBehaviour
{
    //bullet = pew/killEnemy
    void Start()
    {
        GameObject varGameObject = GameObject.Find("pew");
        varGameObject.GetComponent<pewpew>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKey("space"))
        {
            GameObject varGameObject = GameObject.Find("pew");
            varGameObject.GetComponent<pewpew>().enabled = true;
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = false;
        }

    }
}
