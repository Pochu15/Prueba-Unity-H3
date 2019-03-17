using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    bool crouch = false;

    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButton("Jump"))
        {
            jump = true;
            animator.SetBool("Isjumping", true);
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButton("Crouch"))
        {
            crouch = true;
            animator.SetBool("Iscrouching", true);
        } else if (Input.GetButtonUp("Crouch"))
        {
            animator.SetBool("Iscrouching", false);
            crouch = false;
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("Isjumping", false);
    }

    void FixedUpdate()
    {
        // Move our Character
            controller.Move(horizontalMove * Time.fixedDeltaTime , crouch, jump);
        jump = false;

    }
}
