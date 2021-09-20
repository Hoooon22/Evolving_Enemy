using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int playerSpeed; // player speed
    int PlayerJumpPower; // player jump power
    bool m_bJumping = false;

    Rigidbody2D rigid;
    SpriteRenderer rend;
    GameObject obj;
    
    void Start()
    {
        // init
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        obj = GetComponent<GameObject>();
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
        if (Input.GetKey(KeyCode.UpArrow) && obj.CompareTag("Plane")) // Jump
        {
            rigid.AddForce(new Vector2(0, PlayerJumpPower), ForceMode2D.Impulse);
        }
    }
}
