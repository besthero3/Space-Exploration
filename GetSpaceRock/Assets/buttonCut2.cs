using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonCut2 : MonoBehaviour
{
    void Start()
    {
        //for testing

        StartCoroutine(CutsceneLvl2());

    }

    IEnumerator CutsceneLvl2()
    {

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Level_3");

    }
}
