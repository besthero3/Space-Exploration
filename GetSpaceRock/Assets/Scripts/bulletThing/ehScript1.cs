using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ehScript1 : MonoBehaviour
{
    //void OnTriggerEnter2D(Collider2D whatever5)
    //{
    //this script makes it so the bullet doesn't just go on forever once the enemy is dead.
    //  if (whatever5.tag == "acidKiller")
    //{
    //StartCoroutine(AcidReset());
    //}
    //}
  //  void Start()
  //  {
      //  varGameObject3.GetComponent<cameraFollow2>().enabled = false;
    //}
        void Update()
        {
            StartCoroutine(AcidReset());
        }
    IEnumerator AcidReset()
    {
        GameObject varGameObject3 = GameObject.Find("acid?");

        varGameObject3.GetComponent<cameraFollow2>().enabled = true;
        varGameObject3.GetComponent<pewpew1>().enabled = false;
        print("this works!");
        yield return new WaitForSeconds(2);

        varGameObject3.GetComponent<cameraFollow2>().enabled = false;
        varGameObject3.GetComponent<pewpew1>().enabled = true;
        print("Thank fuck!");
        yield return new WaitForSeconds(8);
    }
}
