using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public bool isEnemy;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isEnemy)
        {
            rb.AddForce(Vector2.right * Speed * Time.fixedDeltaTime);
        }
        else if (isEnemy)
        {
            rb.AddForce(Vector2.left * Speed * Time.fixedDeltaTime);
        }

    }


}



