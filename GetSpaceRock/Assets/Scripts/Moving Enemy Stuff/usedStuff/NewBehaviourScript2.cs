using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D whatever)
    {
        //stupidThing is the first collider/ the collider that sends it right
        if (whatever.tag == "stupidThing")
        {
            GameObject varGameObject = GameObject.Find("bee (4)");
            //this disables the script that moves the enemy left and enables the one that moves it right.
            varGameObject.GetComponent<rightname>().enabled = true;
            varGameObject.GetComponent<name>().enabled = false;
        }

    }
}
