using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth2 : MonoBehaviour
{
    public static int enemyHealthNum2 = 30;
    //bullet = pew/killEnemy
    void Update()
    {
        if (enemyHealthNum2 <= 0)
        {
            Destroy(gameObject);
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = true;
        }
    }
}
