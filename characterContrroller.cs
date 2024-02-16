using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterContrroller : MonoBehaviour
{

    Rigidbody2D rigid;
    public float speed = 0;
    Vector2 yon;

    // yeniden doðarken ayarlayýn publicleri
    public bool ableToJump = true;
    public float jumpForce = 0f; // zýplama gücü 3 baþýna karakter boyu

    public bool ableToFly = false;
    bool onFloor;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        yon = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        move();
    }

    private void move()
    {
        if (ableToFly)
        {
            rigid.velocity = yon * speed;
            return;
        }

        yon = new Vector2(yon.x, 0);
        yon.Normalize();
        rigid.velocity = new Vector2(yon.x * speed, rigid.velocity.y);

        if (onFloor && ableToJump && Input.GetButtonDown("Jump")) 
        {
            onFloor = false;
            rigid.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor")) 
        {
            onFloor = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            onFloor = false;
        }
    }
}
