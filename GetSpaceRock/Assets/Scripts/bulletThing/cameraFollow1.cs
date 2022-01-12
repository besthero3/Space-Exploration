using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow1 : MonoBehaviour
{
    //room camera
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    //suivre le carré
    [SerializeField] private Transform player;


    private void Update()
    {
        //bouge salope
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
