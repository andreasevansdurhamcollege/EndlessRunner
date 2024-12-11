using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 3f;
    public float jumpForce = 5f;

    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move the player to the right evey frame
        transform.Translate(Vector2.right * forwardSpeed * Time.deltaTime);

        // Jump if the space key is pressed and the player is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // we can jump again if we collide with something tagged as Ground
        if (collision.gameObject.CompareTag("Ground")) 
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle")) 
        {
            isGrounded = true;
        }
    }

}
