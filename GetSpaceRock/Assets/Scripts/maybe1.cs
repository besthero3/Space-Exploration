using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maybe1 : MonoBehaviour
{
    //bullet = pew/killEnemy
    void Start()
    {
        GameObject varGameObject = GameObject.Find("acid?");
        varGameObject.GetComponent<pewpew1>().enabled = false;
    }

    void Update()
    {
            GameObject varGameObject = GameObject.Find("acid?");
            varGameObject.GetComponent<pewpew1>().enabled = true;
            GameObject varGameObject2 = GameObject.Find("acid?");
            varGameObject2.GetComponent<cameraFollow2>().enabled = false;

    }
}
