using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    int monsterSpeed = 100; 

    Rigidbody2D rigid;
    SpriteRenderer rend;
    GameObject player;
    Vector2 pos;

    void Start()
    {
        // init
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");

        pos = this.gameObject.transform.position;
    }

    void FixedUpdate()
    {
        MonsterMove();
    }

    void Update()
    {
        
    }

    void MonsterMove()
    {
        if (pos.x == player.transform.position.x)
        {
            rigid.AddForce(new Vector2(0, 0), ForceMode2D.Force);
        }
        else if (pos.x > player.transform.position.x)
        {
            rigid.AddForce(new Vector2(-monsterSpeed, 0), ForceMode2D.Force);
        }
        else if (pos.x < player.transform.position.x)
        {
            rigid.AddForce(new Vector2(monsterSpeed, 0), ForceMode2D.Force);
        }
    }
}
