using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpew1 : MonoBehaviour
{

    void Update()
    {
            transform.position += Vector3.up * Time.deltaTime * 1;
    }
}
