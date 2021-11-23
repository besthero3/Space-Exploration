using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text scoree;

    void Start ()
    {
        scoree = GetComponent<Text>();
    }

    void Update ()
    {
        scoree.text = "Score: " + scoreValue;
    }
}
