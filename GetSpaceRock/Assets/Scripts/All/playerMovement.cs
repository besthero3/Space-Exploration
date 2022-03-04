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

        if (other.tag == "MovingEnemy")
        {

            //Subtract one from lives count
            lives.livesCount -= 1;

            //We will also need to add a RESPAWN FEATURE HERE and a transition screen showing the player lost a life. Animation or something 
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
            Debug.Log("-1 life, respawn to beginning of level");
        }

        if (other.tag == "Level_2") {
            SceneManager.LoadScene("FinishedLevel");
            enemyHealth.enemyHealthNum = 30;
        }
        if (other.tag == "Level_3")
        {
            SceneManager.LoadScene("FinishedLevel1");
            enemyHealth.enemyHealthNum = 30;
        }
        if (other.tag == "Level_4")
        {
            SceneManager.LoadScene("FinishedLevel3");
            enemyHealth.enemyHealthNum = 30;
        }
        if (other.tag == "Level_5")
        {
            SceneManager.LoadScene("FinishedLevel3 1");
            enemyHealth.enemyHealthNum = 30;
        }
        if (other.tag == "Level_6")
        {
            SceneManager.LoadScene("FinishedLevel3 2");
            enemyHealth.enemyHealthNum = 30;
        }
        if (other.tag == "Level_7")
        {
            SceneManager.LoadScene("FinishedLevel3 3");
            enemyHealth.enemyHealthNum = 30;
        }
        if (other.tag == "Level_8")
        {
            SceneManager.LoadScene("FinishedLevel3 4");
            enemyHealth.enemyHealthNum = 30;
        }


        if (other.tag == "dialogue1") {
            speed = 0;
            StartCoroutine(Dialogue1());
         //speed = 10; 
            Destroy(other.gameObject);
            //MAKE coroutines
            //Player speed = 0;
        }
        if (other.tag == "dialoge2")
        {
            speed = 0;
            StartCoroutine(Dialogue2());
            //speed = 10; 
            Destroy(other.gameObject);
            //MAKE coroutines
            //Player speed = 0;
        }
        if (other.tag == "dialoge3")
        {
            speed = 0;
            StartCoroutine(Dialogue3());
            //speed = 10; 
            Destroy(other.gameObject);
            //MAKE coroutines
            //Player speed = 0;
        }
        if (other.tag == "dialoge4")
        {
            speed = 0;
            StartCoroutine(Dialogue4());
            //speed = 10; 
            Destroy(other.gameObject);
            //MAKE coroutines
            //Player speed = 0;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Ground" && collision.gameObject.tag != "dialogue1") {
            grounded = true;
            body.gravityScale = 1;
           // speed = 10;

        }
        if (collision.gameObject.tag == "movingPlatform" && collision.gameObject.tag != "dialogue1")
        {
            grounded = true;
            body.gravityScale = 1;
            // speed = 10;

        }
       /* if (collision.gameObject.tag == "movingPlatform1" && collision.gameObject.tag != "dialogue1")
        {
            grounded = true;
            body.gravityScale = 1;
            // speed = 10;

        }
        if (collision.gameObject.tag == "movingPlatform2" && collision.gameObject.tag != "dialogue1")
        {
            grounded = true;
            body.gravityScale = 1;
            // speed = 10;

        }
        if (collision.gameObject.tag == "movingPlatform3" && collision.gameObject.tag != "dialogue1")
        {
            grounded = true;
            body.gravityScale = 1;
            // speed = 10;

        }
        if (collision.gameObject.tag == "movingPlatform4" && collision.gameObject.tag != "dialogue1")
        {
            grounded = true;
            body.gravityScale = 1;
            // speed = 10;

        }
       */
        else if (collision.gameObject.tag == "Wall")
        {
            StartCoroutine(sideWall()); 

        }
        else if (collision.gameObject.tag == "bouncy")
        {
           // body.gravityScale = 0.1; 
            body.velocity = new Vector2(Input.GetAxis("Horizontal"), 11);
            anim.SetTrigger("jump");
            grounded = false;

        }

    }

    IEnumerator sideWall() {

        speed = 6;
        grounded = false;
        body.gravityScale = 2;

        yield return new WaitForSeconds(2);
        speed = 10;
        //grounded = ;
        body.gravityScale = 1;

    }


    IEnumerator Dialogue1()
    {

        dialogueText.text = "Astronaut 1: Thank goodness you found us, Captain! Did you see those robots(?) that were coming after us?";
        yield return new WaitForSeconds(3);

        dialogueText.text = "Astronaut 2: We have bigger problems to worry about. Captain, the Earth… it’s gone.";
        yield return new WaitForSeconds(4);

        dialogueText.text = "Astronaut 1: …";
        yield return new WaitForSeconds(2);

        dialogueText.text = "Astronaut 2: We have enough supplies and fuel on the rocket to finish our original mission, exploring the nearby Andromeda Galaxy for new planets and life forms.";
        yield return new WaitForSeconds(4);

        dialogueText.text = "But now, we won’t just be searching for the sake of science. We have to find a new home, somewhere we can begin again.";
        yield return new WaitForSeconds(3);

        dialogueText.text = "Astronaut 1: What about the other two missions that went into the Andromeda? We should try and contact them to see what they’ve found.";
        yield return new WaitForSeconds(4);

        dialogueText.text = "Astronaut 2: That would be a good idea, but that robot destroyed our comms. We’ll have to go there ourselves. Captain, let’s chart our course for Planet Aeries, touchdown point of the first Andromeda expedition - Artemis 18."; 
        yield return new WaitForSeconds(7);

        dialogueText.text = "To start, collect green item!";
        speed = 10; 
        yield return new WaitForSeconds(1);


        Destroy(blocker);
    }

    IEnumerator Dialogue2()
    {

        dialogueText.text = "Astronaut 1: Captain, come help us! There’s something you need to see!";
        yield return new WaitForSeconds(2);

        dialogueText.text = "Astronaut 2: Be sure to collect all the gears you see along the way… we’re going to need them!";
        yield return new WaitForSeconds(3);

        dialogueText.text = " ";
        speed = 10;
        yield return new WaitForSeconds(1);


        Destroy(blocker);
    }

    IEnumerator Dialogue3()
    {

        dialogueText.text = "Astronaut 1: Here we are, Captain. Planet Aeries. See if you can find the crew members of Artemis 18. Be careful, though - there may be alien life forms lurking about!";
        yield return new WaitForSeconds(4);

        dialogueText.text = " ";
        speed = 10;
        yield return new WaitForSeconds(1);


        Destroy(blocker);
    }

    IEnumerator Dialogue4()
    {

        dialogueText.text = "Artemis Astronaut: Hello there! Are you the captain of the Achilles mission? I was wondering what happened to your ship after your comms went down.";
        yield return new WaitForSeconds(3);

        dialogueText.text = "Artemis Astronaut: Wait, what do you mean, Earth is gone?";
        yield return new WaitForSeconds(2);

        dialogueText.text = "Artemis Astronaut: Well, it’s evident that Planet Aeries isn’t hospitable. These volcanoes and lava monsters don’t exactly make it a good place to live.";
        yield return new WaitForSeconds(4);

        dialogueText.text = "Artemis Astronaut: I’m ready to get out of here. Let’s go to Planet Atropos and find out how the second Andromeda mission, Athena 22, is doing.";
        yield return new WaitForSeconds(4);

        dialogueText.text = " ";
        speed = 10;
        yield return new WaitForSeconds(1);


        Destroy(blocker);
    }
}
 