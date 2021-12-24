using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//CONSUME
//lmao I used a tutorial for the first part of this
//This is specificly for level 2 cause it only works if it is different ig
public class destroyRockWhenCollectlvl2 : MonoBehaviour
{
    //the things have to be triggers for this to work
    //this kills rock
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        //gameObject = rock

        //Adds one to the rocks collected count
        rocksCollectedLevel2.rockCountlvl2++; 
        score.scoreValue += 200;

    }
}
