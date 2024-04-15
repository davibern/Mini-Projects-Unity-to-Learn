using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveInput;
    [SerializeField] private float speed;
    [SerializeField] private float gravity;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        moveInput.x *= speed;
        moveInput.z *= speed;

        if (!controller.isGrounded)
            moveInput.y -= gravity;

        controller.Move(moveInput);
    }
}
