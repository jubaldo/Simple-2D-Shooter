using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Use this for initialization
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public int damage = 20;
    public float speed = 20f;

    // Update is called once per frame
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);


    }
}
