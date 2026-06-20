using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public float speed;
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += (Vector3.right * x * speed * Time.deltaTime);
    }
}


