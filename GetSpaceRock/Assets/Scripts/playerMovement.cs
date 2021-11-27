using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]private float speed; 
    private Rigidbody2D body;
    //private Transform playerStartingPosition; 

    private void Awake()
    {
      //  playerStartingPosition = GetComponent<Transform>(); 
        body = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {

        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.UpArrow)) {
            body.velocity = new Vector2(Input.GetAxis("Horizontal"), 6);          
        }
    }

    //Checks if the player's collider has collided with another 2D collider
    void OnTriggerEnter2D(Collider2D other) {

        //If the other object has a tag eqaul to enemy...
        //Tags can be set and created in the Unity Hierchy
        if (other.tag == "Enemy") {

            //Subtract one from lives count
            lives.livesCount -= 1;

            //We will also need to add a RESPAWN FEATURE HERE and a transition screen showing the player lost a life. Animation or something 
        }
    }
}
 