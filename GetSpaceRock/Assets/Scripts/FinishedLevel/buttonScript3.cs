using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Muy importante
using UnityEngine.SceneManagement;

public class buttonScript3 : MonoBehaviour
{
    void OnMouseUp()
    {
        //for testing
        print("Please Work");
        //This sends the user to Level 2
        SceneManager.LoadScene("Level_4");
    }
}
