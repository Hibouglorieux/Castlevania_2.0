using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected float max_speed = 20;
    [SerializeField] protected float acceleration = 1;
    protected float speed_multiplier = 1;
    [SerializeField] protected Rigidbody2D rb;

    void Start()
    {
        
    }

    void deplacement ()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) && Mathf.Abs(rb.velocity.x) < max_speed)
            rb.AddForce(new Vector2(1, 0));
    }

    void Update()
    {
        deplacement();
    }
}
