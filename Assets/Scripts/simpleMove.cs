using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMove : MonoBehaviour
{
    Rigidbody2D rb;
    //Animator anim;
    public float speed = 2f;
    Vector2 vel;
    public Vector2 jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        vel = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            vel = new Vector2(-speed, 0);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel = new Vector2(speed, 0);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        //anim.SetFloat("runSpeed", Mathf.Abs(vel.x + vel.y));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            vel = new Vector2(0, 15);
        }

        
    }

    void FixedUpdate()
    {
        rb.velocity = vel;
    }
}
