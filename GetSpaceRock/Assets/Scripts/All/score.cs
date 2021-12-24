using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    //Declares Variables
    //Score starts at 0
    //SerializeField allows that variable to be seen and changed in Unity
    public static int scoreValue = 0;
    [SerializeField]public Text scoree;

    void Update ()
    {
        //Updates the Score text
        scoree.text = "Score: " + scoreValue;
    }
}
