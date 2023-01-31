using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator animator;
    public float speed;
    private Vector2 movement;
    bool facingRight = true;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(movement.x * speed, movement.y * speed);

        runAnim();

        if(rb.velocity.x < 0 && facingRight)
        {
            FlipFace();
        }
        else if(rb.velocity.x > 0 && !facingRight)
        {
            FlipFace();
        }
    }

    private void runAnim()
    {
        if(movement.x != 0 || movement.y != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }

    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 tempLocaleScale = transform.localScale;
        tempLocaleScale.x *= -1;
        transform.localScale = tempLocaleScale;
    }

}
