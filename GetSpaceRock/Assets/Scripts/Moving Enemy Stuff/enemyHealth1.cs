using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth1 : MonoBehaviour
{
    public static int enemyHealthNum1 = 30;
    //bullet = pew/killEnemy
    void Update()
    {
        if (enemyHealthNum1 <= 0)
        {
            Destroy(gameObject);
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = true;
        }
    }
}
