using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth3 : MonoBehaviour
{
    public static int enemyHealthNum3 = 30;
    //bullet = pew/killEnemy
    void Update()
    {
        if (enemyHealthNum3 <= 0)
        {
            Destroy(gameObject);
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = true;
        }
    }
}
