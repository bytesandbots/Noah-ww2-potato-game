using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Transform defensiveSpot;
    public float speed = 1f;
    public int health;

    public enum State { Attacking, Defending, Retreating }
    public State currentState;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentState = State.Attacking;
    }

    void Update()
    {
        if (health <= 0) Destroy(gameObject);
        switch (currentState)
        {
            case State.Attacking:
                Attack();
                break;
            case State.Defending:
                Defend();
                break;
            case State.Retreating:
                Retreat();
                break;
        }

        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void Attack()
    {
        speed = 1f;
    }

    void Defend()
    {
        speed = 0f;

    }

    void Retreat()
    {
        speed = -1f;

        if (transform.position.x <= -15)
        {
            speed = 0f;
        }
    }
}


