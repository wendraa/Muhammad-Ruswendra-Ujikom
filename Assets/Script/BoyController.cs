using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 3.0f;
    private float gravityValue = -9.81f;

    private Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if(groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
            animator.SetBool("isLeft", true);
            Debug.Log("Klik");
        }

        else
        {
            animator.SetBool("isLeft", false);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
        
    }
}

