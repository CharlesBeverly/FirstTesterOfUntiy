using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    bool can_jump;
    // Start is called before the first frame update
    void Start()
    {
        can_jump = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (can_jump)
            {
                if (rb.velocity.y < 10)
                {
                    rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y+2);
                }
                else{
                    can_jump = false;
                }
            }
        }
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
