using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingEnemyButItMightActuallyWork : MonoBehaviour
{
    void Update()
    {
        float positionx = gameObject.transform.position.x;
        int whatever = 0;

        //transform.position += Vector3.left * Time.deltaTime;

        if (positionx == 3)
        {
            print("why does nothing fucking work");
            whatever = 2;
            Destroy(GetComponent<MovingEnemyscript1>());
        }
        else if (positionx == 9)
        {
            print("why does nothing fucking work 5");
            transform.position += Vector3.left * Time.deltaTime;
            whatever = 1;
        }
        switch (whatever)
        {
            case 1:
                //transform.position += Vector3.left * Time.deltaTime;
                print("why does nothing fucking work 2");
                break;
            case 2:
                transform.position += Vector3.right * Time.deltaTime;
                print("why does nothing fucking work 3");
                Destroy(GetComponent<MovingEnemyscript1>());
                break;
            //default:
              //  transform.position += Vector3.left * Time.deltaTime;
                //print("why does nothing fucking work 7598");
                //break;
        }

    }
}
