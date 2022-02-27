using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonCut1 : MonoBehaviour
{
    buttonScript myObj = new buttonScript(); 
    
    void Start()
    {
        //for testing
        
       StartCoroutine(CutsceneLvl());

    }

    IEnumerator CutsceneLvl() {

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Level_2");

    }



}
