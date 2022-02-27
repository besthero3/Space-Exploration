using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void cutsceneCall()
    {
      //StartCoroutine("delay)
    }

    // Update is called once per frame
    IEnumerator delay() {
        yield return new WaitForSeconds(2); 
    }

    
}
