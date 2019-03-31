using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected float max_speed;
    [SerializeField] protected float acceleration;
    protected float speed_multiplier = 1;
    [SerializeField] protected Rigidbody2D rb;
    protected short max_jumps = 1;
    protected short jump_left;
    [SerializeField] Collider2D collider;

    void Start()
    {
        jump_left = max_jumps;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        jump_left = max_jumps;
    }

    void deplacement ()
    {
        Debug.Log(rb.velocity.x);
        if (Input.GetKey(KeyCode.RightArrow) && rb.velocity.x < max_speed)
            rb.AddForce(new Vector2(acceleration, 0));
        if (Input.GetKey(KeyCode.LeftArrow) & rb.velocity.x > -max_speed)
            rb.AddForce(new Vector2(-acceleration, 0));
        if (rb.velocity.x > max_speed)
            rb.velocity = new Vector2(max_speed, rb.velocity.y);
        if (rb.velocity.x < -max_speed)
            rb.velocity = new Vector2(-max_speed, rb.velocity.y);
        if (jump_left > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 25);
            jump_left--;
        }

    }

    void Update()
    {
        deplacement();
    }
}
