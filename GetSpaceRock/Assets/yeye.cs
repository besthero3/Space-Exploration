using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeye : MonoBehaviour
{
    public Transform gameObject;

    void OnTriggerEnter()
    {
        Destroy(gameObject);
    }

}
