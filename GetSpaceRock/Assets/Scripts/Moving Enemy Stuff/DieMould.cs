using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieMould : MonoBehaviour
{
    AudioSource playMusic3;
    public AudioClip hit;

    private void Start()
    {
        playMusic3 = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D whatever3)
    {
        //bullet = pew/killEnemy
        if (whatever3.tag == "killEnemy")
        {
            //playMusic3.PlayOneShot(hit, 1F);
            enemyHealth.enemyHealthNum -= 10;
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = true;
        }

    }
}
