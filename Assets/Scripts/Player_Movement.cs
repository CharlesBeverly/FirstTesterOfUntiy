using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    bool can_jump;
    bool jumping = false;
    float jumpVel = 0;
    // Start is called before the first frame update
    void Start()
    {
        can_jump = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void jump() // LOL QUIRKY
    {
        if(jumpVel != 0)
        {
            if(rb.velocity.y < 10)
            {
                Debug.Log(rb.velocity.y);
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + jumpVel);
            }
            else
            {
                can_jump = false;
                jumpVel = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (can_jump)
            {
                jumpVel = 0.5f;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            can_jump = false;
            jumpVel = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        jump();
        if(Input.GetKey(KeyCode.D)) {
            if(rb.velocity.x < 10)
            {
                rb.velocity = new Vector2(10, rb.velocity.y);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if(rb.velocity.x > -10) {
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

