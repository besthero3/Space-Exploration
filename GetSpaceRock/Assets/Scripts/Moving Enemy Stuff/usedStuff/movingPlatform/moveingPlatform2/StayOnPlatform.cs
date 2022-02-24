using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnPlatform : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D whatever2)
    {
        if (whatever2.tag == "movingPlatform")
        {
            GameObject varGameObject = GameObject.Find("player-stand-1");
            varGameObject.GetComponent<cameraFollow3>().enabled = true;
        }
       /* if (whatever2.tag == "movingPlatform1")
        {
            GameObject varGameObject = GameObject.Find("player-stand-1");
            varGameObject.GetComponent<cameraFollow4>().enabled = true;
        }
        if (whatever2.tag == "movingPlatform2")
        {
            GameObject varGameObject = GameObject.Find("player-stand-1");
            varGameObject.GetComponent<cameraFollow5>().enabled = true;
        }
        if (whatever2.tag == "movingPlatform3")
        {
            GameObject varGameObject = GameObject.Find("player-stand-1");
            varGameObject.GetComponent<cameraFollow6>().enabled = true;
        }
        if (whatever2.tag == "movingPlatform4")
        {
            GameObject varGameObject = GameObject.Find("player-stand-1");
            varGameObject.GetComponent<cameraFollow7>().enabled = true;
        }
       */

    }
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GameObject varGameObject = GameObject.Find("player-stand-1");
          varGameObject.GetComponent<cameraFollow3>().enabled = false;
      /*      varGameObject.GetComponent<cameraFollow4>().enabled = false;
            varGameObject.GetComponent<cameraFollow5>().enabled = false;
            varGameObject.GetComponent<cameraFollow6>().enabled = false;
            varGameObject.GetComponent<cameraFollow7>().enabled = false; */
        }
    }
}
