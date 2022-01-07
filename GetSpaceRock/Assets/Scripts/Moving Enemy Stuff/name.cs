using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class name : MonoBehaviour
{
    void Update()
    {
        //this moves the enemy left
        transform.position += Vector3.left * Time.deltaTime;
    }
}
