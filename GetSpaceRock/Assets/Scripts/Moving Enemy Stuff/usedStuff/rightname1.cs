using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightname1 : MonoBehaviour
{
    void Update()
    {
        //this moves the enemy right
        transform.position += Vector3.right * Time.deltaTime;
    }
}
