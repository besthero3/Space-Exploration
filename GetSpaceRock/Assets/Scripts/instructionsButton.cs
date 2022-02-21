using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instructionsButton : MonoBehaviour
{
    void OnMouseUp()
    {
        //for testing
        print("Please Work");
        //This sends the user to Level 2
        //Instructions: Tips: Use the help menu. Try to jump without coming into contact with the sides of the platform. If you hit the side of the platform the player will be staggered for a couple seconds. 
        SceneManager.LoadScene("dedication");
    }
}
