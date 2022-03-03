using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth5 : MonoBehaviour
{
    public static int enemyHealthNum5 = 30;
    //bullet = pew/killEnemy
    void Update()
    {
        if (enemyHealthNum5 <= 0)
        {
            Destroy(gameObject);
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = true;
        }
    }
}
