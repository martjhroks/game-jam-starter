using UnityEngine;

public class PlayerController_SideScroller : MonoBehaviour
{
    private Rigidbody2D rb;

    [Header("Movement")]
    public float speed = 5f;

    [Header("Jump Settings")]
    public float jumpForce = 12f;
    public float jumpCutMultiplier = 0.5f; // Cuts jump if the button is released early
    public float coyoteTime = 0.1f; // Grace time after leaving the ground
    public float jumpBufferTime = 0.1f; // Buffer time for jump input

    private float coyoteTimeCounter;
    private float jumpBufferCounter;

    private bool isJumping;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move Left/Right
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * speed, rb.linearVelocity.y);

        // Grounded Check using Raycast
        bool isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1.1f, LayerMask.GetMask("Ground"));

        if (isGrounded)
        {
            coyoteTimeCounter = coyoteTime;
        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jumpBufferCounter = jumpBufferTime; 
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }

        if (jumpBufferCounter > 0 && coyoteTimeCounter > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isJumping = true;
        }

        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * jumpCutMultiplier);
        }
    }
}
