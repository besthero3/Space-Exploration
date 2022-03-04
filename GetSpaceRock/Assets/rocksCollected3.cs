using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//m u y  i m p o r t a n t e
using UnityEngine.SceneManagement;

//This is specificly for level 2 cause Unitys a bitch
public class rocksCollected3 : MonoBehaviour

{

    //rocksCollected plusObj = new rocksCollected();

    //Declaring Variables
    //Rocks Collected starts at 0

    public static int rockCountlvl3 = 0 + rocksCollectedLevel2.rockCountlvl2;

    public Text rockText;



    void Update()
    {
        //Checks if 5 rocks have been collected... 
        //We can change this number later if needed
        if (rockCountlvl3 == 5)
        {
            //Adds a life
            lives.livesCount += 1;

            //Resets the amount of rocks collected
            rockCountlvl3 = 0;

            //Console Message that displays extra life
            //We will put a sound effect in place here
            Debug.Log("Extra Life");

            /*This makes it so once you get all of the rocks, or 
             * finish the level, it sends you to an end screen 
             * where you have the option to go to the next level.*/
            //SceneManager.LoadScene("FinishedLevel");
        }

        //Updates the rock collection text
        rockText.text = "Gears: " + rockCountlvl3;


    }
}
