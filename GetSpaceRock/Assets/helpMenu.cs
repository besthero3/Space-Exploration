using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpMenu : MonoBehaviour
{
    public GameObject instructions; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            instructions.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.H))
        {
            instructions.SetActive(false);
        }
    }
}
