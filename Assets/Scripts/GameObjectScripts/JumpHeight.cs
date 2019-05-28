using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHeight : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 5f;

    [SerializeField]
    private float gravityScale = 1f;

    [SerializeField]
    private float jumpTimer = 0.5f;

    private bool pressedJump = false;

    private Rigidbody2D rb;

    private bool releasedJump = false;

    private bool startTimer = false;

    private float timer;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        timer = jumpTimer;
    }

    private void Update()
    {

        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        {
            pressedJump = true;
        }

        if (Input.GetButtonUp("Jump"))
        {
            releasedJump = true;
        }

        /* For Touch Controls */
        /*//////////////////////////////////////////////////////////////
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began && rb.velocity.y == 0)
            {
                pressedJump = true;
            }

            if (touch.phase == TouchPhase.Ended && rb.velocity.y == 0)
            {
                releasedJump = true;
            }
        }
        ////////////////////////////////////////////////////////////////
        */

        if (startTimer)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                releasedJump = true;
            }
        }
    }

    private void FixedUpdate()
    {
        if (pressedJump)
        {
            StartJump();
        }

        if (releasedJump)
        {
            StopJump();
        }
    }

    private void StartJump()
    {
        rb.gravityScale = 0;
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        pressedJump = false;
        startTimer = true;
    }

    private void StopJump()
    {
        rb.gravityScale = this.gravityScale;
        releasedJump = false;
        timer = jumpTimer;
        startTimer = false;
    }
}
