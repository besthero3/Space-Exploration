using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//CONSUME
//lmao I used a tutorial for the first part of this
public class rocks4 : MonoBehaviour
{
    //the things have to be triggers for this to work
    //this kills rock
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            //gameObject = rock
            rocksCollected4.rockCountlvl4++;
            score.scoreValue += 200;
        }
        //Adds one to the rocks collected count

    }
}
