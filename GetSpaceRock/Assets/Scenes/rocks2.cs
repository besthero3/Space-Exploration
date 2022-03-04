using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//CONSUME
//lmao I used a tutorial for the first part of this
public class rocks2 : MonoBehaviour
{
    //the things have to be triggers for this to work
    //this kills rock
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            //gameObject = rock
            rocksCollectedLevel2.rockCountlvl2++;
            score.scoreValue += 200;
        }
        //Adds one to the rocks collected count

    }
}
