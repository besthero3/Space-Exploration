using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]private float speed; 
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {

        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.UpArrow)) {
            body.velocity = new Vector2(Input.GetAxis("Horizontal"), 6);

        }
    }
}
 