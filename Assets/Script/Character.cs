using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 250.0f;
    //float walkForce = 30.0f;
    //float maxWalkSpeed = 200.0f;
    public Vector2 Player;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 점프
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        Player = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.x += 0.034f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.x -= 0.034f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player.y += 0.034f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.y -= 0.034f;
        }

        transform.Translate(Player);

        // 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //transform.localScale = new Vector3(-1, 1, 1);
       // transform.localScale = new Vector3(1, 1, 1);
    }
}
