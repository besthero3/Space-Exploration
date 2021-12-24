using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]private float speed; 
    private Rigidbody2D body;
    //private Transform playerStartingPosition; 
    private Animator anim;
    private bool grounded; 
       

    private void Awake()
    {
      //  playerStartingPosition = GetComponent<Transform>();
      //Grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); 
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        //Flip Player when moving left-right
        if(horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(4, 4, 4); 
        }
        else if(horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-4, 4, 4);
        }

        if (Input.GetKey(KeyCode.UpArrow) && grounded) {
            jump();      
        }

        //Set animator parameters
        anim.SetBool("Run", horizontalInput != 0);
        anim.SetBool("grounded", grounded); 
    }

    private void jump()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal"), 6);
        anim.SetTrigger("jump"); 
        grounded = false; 
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            grounded = true;
        }
    }

}
 