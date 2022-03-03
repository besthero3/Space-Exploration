using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieMould1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D whatever3)
    {
        //bullet = pew/killEnemy
        if (whatever3.tag == "killEnemy")
        {
            enemyHealth1.enemyHealthNum1 -= 10;
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = true;
        }

    }
}
