using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{
    //Declaring Variables
    //Player Starts with 5 lives
    public static int livesCount = 5; 
    public Text lifeText;
    public GameObject gameOverText;

    private void Start()
    {
        //Sets the gameOverText activity to false, meaning it is disabled for now andc can not be seen(at start of game)
        gameOverText.SetActive(false);
    }

    void Update()
    {
        //If the life count is less than or equal to 0; player has died
        if (livesCount <= 0)
        {
            //Temporary Solution
            //Sets the gameOverText to active so it can be seen
            gameOverText.SetActive(true);
        }

        //Updates the life text
        lifeText.text = ": " + livesCount;
    }
}
