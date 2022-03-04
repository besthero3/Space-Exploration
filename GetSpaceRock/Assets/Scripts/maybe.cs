using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maybe : MonoBehaviour
{
    AudioSource playMusic;
    public AudioClip shoot; 

    //bullet = pew/killEnemy
    void Start()
    {
        GameObject varGameObject = GameObject.Find("pew");
        varGameObject.GetComponent<pewpew>().enabled = false;
        playMusic = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (Input.GetKey("space"))
        {
            //playMusic.PlayOneShot(shoot, 1F);
            GameObject varGameObject = GameObject.Find("pew");
            varGameObject.GetComponent<pewpew>().enabled = true;
            GameObject varGameObject2 = GameObject.Find("pew");
            varGameObject2.GetComponent<cameraFollow1>().enabled = false;
        }

    }
}
