using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform visualObj;
    private Vector2 moveDirection;

    private void Update()
    {
        if (Time.timeScale != 0f)
        {
            Movement();
            VisualRotation();
        }
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        moveDirection = new(horizontalInput, verticalInput);
        moveDirection.Normalize();

        transform.Translate(moveSpeed * Time.deltaTime * moveDirection);
    }

    private void VisualRotation()
    {    
        if (moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            visualObj.eulerAngles = new(0f, 0f, angle);
        }            
    }
}
