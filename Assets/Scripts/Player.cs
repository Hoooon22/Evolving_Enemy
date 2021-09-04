using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float playerSpeed = 10; // player speed
    Rigidbody2D rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); // init
    }

    void Update()
    {
        
    }

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow)) // RightArrow
        {
            rigid.AddForce(new Vector2(playerSpeed, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) // LeftArrow
        {
            rigid.AddForce(new Vector2(-playerSpeed, 0), ForceMode2D.Force);
        }
    }
}
