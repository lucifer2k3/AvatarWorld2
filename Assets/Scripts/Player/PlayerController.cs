using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    private Animator anim;

    private Rigidbody2D rb;

    public float speed = 5f;
    //[SerializeField]public Sprite[] itemImage;
    //[SerializeField]public Image usingItemImage;
    private bool Moving;

    private Vector2 input;

    private float x;
    private float y;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        GetInput();
        Animate();
    }
    void FixedUpdate()
    {
        rb.velocity = input * speed;
    }
    private void GetInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        input = new Vector2(x,y);
        input.Normalize();
    }
    private void Animate()
    {
        if (input.magnitude > 0.1f || input.magnitude < -0.1f)
        {
            Moving = true;
        }
        else
        {
            Moving = false;
        }
        if (Moving)
        {
            anim.SetFloat("x", x);
            anim.SetFloat("y", y);
        }
        anim.SetBool("IsMoving", Moving);
    }
}
