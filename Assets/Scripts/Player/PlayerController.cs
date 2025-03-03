using UnityEngine;

[RequireComponent (typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;
    public Transform PlayerMesh;

    private CharacterController characterController;
    private Vector3 moveDirection;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection = Vector3.zero;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0, targetAngle, 0);
            PlayerMesh.rotation = Quaternion.Lerp(PlayerMesh.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
        }

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}
