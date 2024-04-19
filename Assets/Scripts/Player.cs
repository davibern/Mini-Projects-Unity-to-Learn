using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float gravity;
    [SerializeField] private float speed;
    private CharacterController controller;
    private Vector3 moveInput;
    private Vector3 mousePosition;
    private Vector3 direction;
    private Vector3 playerPosition;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        GetPosition();
        Rotate();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void GetPosition()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");

        // Get the mouse position
        mousePosition = Input.mousePosition;
        // Get the position about world not the object position
        playerPosition = Camera.main.WorldToScreenPoint(transform.position);
    }

    private void Movement()
    {
        moveInput.x *= speed;
        moveInput.z *= speed;

        if (!controller.isGrounded)
            moveInput.y -= gravity;

        controller.Move(moveInput);
    }

    private void Rotate()
    {
        // Calculate the direction in which we have to move, so is the direction we have to rotate
        direction = mousePosition - playerPosition;

        // Set the rotation to this direction our player automatically
        float rotationAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate our player with a particular value around an axis (in this case around Y axis)
        transform.rotation = Quaternion.AngleAxis(-rotationAngle, Vector3.up);
    }
}
