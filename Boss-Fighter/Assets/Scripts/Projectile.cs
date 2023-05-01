using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rb;
    public float projectileSpeed = 30f;
    public float deadZoneL = -30;
    public float deadZoneR = 30;
    public float projectileDamage = 10;
    

    void Start()
    {
        rb.velocity = transform.right * projectileSpeed;
    }

    void Update()
    {
        if (transform.position.x < deadZoneL || transform.position.x > deadZoneR)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.name != "Player")
        {
            Destroy(gameObject);
        }
            
    }

    /* uncomment when bosshealth script is implemented */
    // private void OnCollisionEnter2D(Collider2D collision)
    // {
    //     var enemy = collision.collider.GetComponent<BossHealth>(); // temp name
    //     if (enemy)
    //     {
    //         enemy.takeHit(projectileDamage);
    //     }
    //     Destroy(gameObject);
    // }
}
