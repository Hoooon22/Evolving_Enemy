using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int playerSpeed = 100; // player speed
    int PlayerJumpPower = 80; // player jump power
    int jumpCount = 1; // jump count

    Rigidbody2D rigid;
    SpriteRenderer rend;
    
    void Start()
    {
        // init
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        PlayerMove();
        PlayerJump();
    }

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow)) // RightArrow
        {
            rend.flipX = false;
            rigid.AddForce(new Vector2(playerSpeed, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) // LeftArrow
        {
            rend.flipX = true;
            rigid.AddForce(new Vector2(-playerSpeed, 0), ForceMode2D.Force);
        }
    }
    
    void PlayerJump()
    {
        if (jumpCount > 0 && Input.GetKey(KeyCode.UpArrow)) // Jump
        {
            rigid.AddForce(new Vector2(0, PlayerJumpPower), ForceMode2D.Impulse);
            jumpCount--;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumpCount = 1;
        }
    }
}
