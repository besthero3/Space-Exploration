

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movingEnemyButItMightActuallyWork : MonoBehaviour
{
    private void Start()
    {
        
    }

    void Update()
    {
        int whatever;

        float positionx = gameObject.transform.position.x;
        
        bool direction = true;

        //transform.position += Vector3.left * Time.deltaTime;

        
        
        if (positionx <= 3)
        {
            print("why does nothing fucking work");
            //whatever = 2;
            // transform.position += Vector3.right * Time.deltaTime;
            direction = false;
        }
        else if (positionx == 9)
        {
            print("why does nothing fucking work 5");
            //  transform.position += Vector3.left * Time.deltaTime;
            // whatever = 1;
            direction = true; 
        }

        if (direction) {
            transform.position += Vector3.left * Time.deltaTime;
        }
        if (!direction)
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

        switch (whatever)
        {
            case 1:
                transform.position += Vector3.left * Time.deltaTime;
                print("why does nothing fucking work 2");
                break;
            case 2:
                transform.position += Vector3.right * Time.deltaTime;
                print("why does nothing fucking work 3");
                break; 
          
                //  transform.position += Vector3.left * Time.deltaTime;
                //print("why does nothing fucking work 7598");
                //break;
        }

    }
}
*/