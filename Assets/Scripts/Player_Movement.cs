using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public bool can_jump;
    bool jumping = false;
    float jumpVel = 0;
    BoxCollider2D HurtBox;
    public float HorizontalMaxSpeed = 5;
    public float JumpVelocChange;
    public float LowestJumpVel;
    public float StartSpeed;

    // Start is called before the first frame update
    void Start()
    {
        can_jump = true;
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        HurtBox = GetComponentInChildren<BoxCollider2D>();
    }

    void jump() 
    {
        if(jumpVel != 0)
        {
            jumpVel = jumpVel * JumpVelocChange;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (can_jump)
            {
                jumpVel = StartSpeed;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            can_jump = false;
            jumpVel = 0;
        }
        if (jumpVel != 0)
        {
            if(jumpVel > LowestJumpVel)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + jumpVel);
            }
            else
            {
                can_jump = false;
                jumpVel = 0;
            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        jump();
        if(Input.GetKey(KeyCode.D)) {
            if(rb.velocity.x < HorizontalMaxSpeed)
            {
                rb.velocity = new Vector2(rb.velocity.x+1, rb.velocity.y);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if(rb.velocity.x > -HorizontalMaxSpeed) {
                rb.velocity = new Vector2(rb.velocity.x - 1, rb.velocity.y);
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            
        }
    }
}

