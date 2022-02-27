using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Muy importante
using UnityEngine.SceneManagement;
using System;

public class buttonScript : MonoBehaviour
{
    void OnMouseUp()
    {
        //for testing
        //Scene currentScene = SceneManager.GetActiveScene();
        //public static String current = currentScene.name; 


        print("Please Work");
        //This sends the user to Level 2
        SceneManager.LoadScene("cutscene");

        StartCoroutine(CutsceneLvl());

    }

    IEnumerator CutsceneLvl() {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Level_2");

    }
}
