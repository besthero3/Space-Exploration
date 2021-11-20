using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whywontthiswork : MonoBehaviour
{
    //room camera fuckers
    [SerializeField] private float speed;
private float hereNowX;
private Vector3 velocity = Vector3.zero;

//follow the bitch
[SerializeField] private Transform player;


private void Update()
{
    //this is the room camera beucase I totally know what that is
    //transform.position = Vector3.SmoothDamp(transform.postion, new Vector3(hereNowX, transform.position.y, transform.position.z), ref velocity, speed * Time.deltaTime);

    //follow the thing
    transform.position = new Vector3(player.position.x, transform.position.y, transform.z);
}

public void LeaveRoomNewRoom(Transform _newRoom)
{
    hereNowX = _newRoom.position.x;
}
}
