using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    AudioSource playMusic2; 
    public static int enemyHealthNum = 30;
    public AudioClip death;





    //bullet = pew/killEnemy
    void Update()
    {
        if (enemyHealthNum <= 0)
        {
            playMusic2 = GetComponent<AudioSource>();
            playMusic2.PlayOneShot(death, 1F);
            Destroy(gameObject);
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = true;
        }
    }
}
