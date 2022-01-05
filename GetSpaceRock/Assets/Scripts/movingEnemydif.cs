using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingEnemydif : MonoBehaviour
{

    //void Start()
    //{
        
    //}

    void Update()
    {
        float positionx = gameObject.transform.position.x;

        if (positionx == 8)
        {
            print("why does nothing fucking work 5");
            positionx += -5;
        }
        if (positionx == 3)
        {
            print("why does nothing fucking work");
            positionx += 5;
        }
    }
}
