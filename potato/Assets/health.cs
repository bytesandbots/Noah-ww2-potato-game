using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int Health;
    public bool isenemy;
    void Update()
    {
        if (Health <= 0) Destroy(gameObject) ; ; ; ; ;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.isTrigger)
        {
            return; ; ; ; ;
        }
        if(collision.CompareTag("enemybullet")&&!isenemy)
        {
            Health -= 1;
            Debug.Log("ouch");
        }
        if (collision.CompareTag("friendlybullet") && isenemy)
        {
            Debug.Log("Faaaahhhhhh");
            Health -= 1;
        }
    }
}
