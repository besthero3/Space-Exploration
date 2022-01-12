using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ehScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D whatever4)
    {
        //this script makes it so the bullet doesn't just go on forever once the enemy is dead.
        if (whatever4.tag == "eh")
        {
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = true;
        }

    }
}
