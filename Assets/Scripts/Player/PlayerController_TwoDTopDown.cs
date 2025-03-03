using UnityEngine;

public class PlayerController_TwoDTopDown: MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    private float horizontalInput = 0f;
    private float verticalInput = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = 0;
        if (Input.GetAxis("Horizontal") != 0)
        {
            horizontalInput = Input.GetAxis("Horizontal");
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            verticalInput = Input.GetAxis("Vertical");
        }

        float movementX = horizontalInput * speed;
        float movementY = verticalInput * speed;

        rb.linearVelocity = new Vector2(movementX, movementY);
    }
}
