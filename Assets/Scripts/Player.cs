using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int playerSpeed = 100; // player speed
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
        if (Input.GetKey(KeyCode.UpArrow)) // Jump
        {
            rigid.AddForce(new Vector2(0, playerSpeed), ForceMode2D.Force);
        }
    }
}
