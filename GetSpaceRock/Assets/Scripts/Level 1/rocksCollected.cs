using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//m u y  i m p o r t a n t e
using UnityEngine.SceneManagement;

public class rocksCollected : MonoBehaviour
{
    //Declaring Variables
    //Rocks Collected starts at 0
    public Text rockText;

    public static int rockCount = 0;

    void Update()
    {
        //Checks if 5 rocks have been collected... 
        //We can change this number later if needed
        if (rockCount == 5)
        {
            //Adds a life
            lives.livesCount += 1;

            //Resets the amount of rocks collected
            rockCount = 0;

            //Console Message that displays extra life
            //We will put a sound effect in place here
            Debug.Log("Extra Life");

            /*This makes it so once you get all of the rocks, or 
             * finish the level, it sends you to an end screen 
             * where you have the option to go to the next level.*/
            //SceneManager.LoadScene("FinishedLevel");
            //SceneManager.LoadScene(sceneBuildIndex+1); 
        }

        //Updates the rock collection text
        rockText.text = "Gears: " + rockCount;


    }
}
