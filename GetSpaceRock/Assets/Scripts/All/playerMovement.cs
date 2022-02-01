using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class playerMovement : MonoBehaviour
{
    [SerializeField]private float speed; 
    private Rigidbody2D body;
    //private Transform playerStartingPosition; 
    private Animator anim;
    private bool grounded;
    public Text dialogueText;
    public Image dialogueTextBackground;
    public GameObject blocker; 
    

    private void Awake()
    {
      //  playerStartingPosition = GetComponent<Transform>();
      //Grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //float positionx = gameObject.transform.position.x;
    }
    
    private void Update()
    {
        //transform.localPosition.x = positionx.x;
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
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
            Debug.Log("-1 life, respawn to beginning of level");
        }

        if (other.tag == "Level_2") {
            SceneManager.LoadScene("Level_2");
        }
        if (other.tag == "Level_3")
        {
            SceneManager.LoadScene("GameOver");
        }
        if (other.tag == "dialogue1") {
            StartCoroutine(Dialogue());
            Destroy(other.gameObject);
            //MAKE coroutines
            //Player speed = 0;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            grounded = true;
        }
    }

    IEnumerator Dialogue()
    {
        dialogueText.text = "Player: Hello fellow astronauts, I just woke up from a nap.";
        yield return new WaitForSeconds(4);

        dialogueText.text = "Crew member: Hi <insert player name>, good to get some sleep before our mission ends and we go back to Earth in two days, it will be the start of 2254.";
        yield return new WaitForSeconds(7);

        dialogueText.text = "Player: Yeah what a great day...";
        yield return new WaitForSeconds(3);

        dialogueText.text = "Crew member 2: Wait what's that out the window?!!";
        yield return new WaitForSeconds(4);

        dialogueText.text = "(Play sound effect here/create image?)";
        yield return new WaitForSeconds(3);

        dialogueText.text = "Player: Earth... its gone";
        yield return new WaitForSeconds(2);

        dialogueText.text = "Player: Hurry get away from the debris, move further away!! "; 
        yield return new WaitForSeconds(4);

        dialogueText.text = "Crew member: Got it captain!";
        yield return new WaitForSeconds(3);

        dialogueText.text = "A short time later...";
        yield return new WaitForSeconds(4);

        dialogueText.text = "Crewmate: Now that we are safe, what do we do?";
        yield return new WaitForSeconds(4);

        dialogueText.text = "Player: We have to rescue our astronauts on Mars and Jupiter";
        yield return new WaitForSeconds(4);

        dialogueText.text = "Crew mate: What then? If Earth is gone what do we do?";
        yield return new WaitForSeconds(3);

        dialogueText.text = "Player: Then we need to see if planets are habitable so we can survive and try to carry on civilization...";
        yield return new WaitForSeconds(5);

        dialogueText.text = "Crewmate: The computer has identified six possible candidates";
        yield return new WaitForSeconds(5);

        dialogueText.text = "Player: And so the mission begins...";
        yield return new WaitForSeconds(5);

        Destroy(blocker);
    }
}
 