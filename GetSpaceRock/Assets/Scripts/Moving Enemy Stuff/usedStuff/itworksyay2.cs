using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itworksyay2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D whatever2)
    {
        //stupid thing2 is the second colliders tag/ the collider that moves it left
        if (whatever2.tag == "stupidThing2")
        {
            GameObject varGameObject = GameObject.Find("bee");
            //this disables the script that moves the enemy right and enables the one that moves it left.
            varGameObject.GetComponent<rightname>().enabled = false;
            varGameObject.GetComponent<name>().enabled = true;
        }

    }
}
