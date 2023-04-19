using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rb;
    public float projectileSpeed = 30f;
    public float deadZoneL = -30;
    public float deadZoneR = 30;
    

    void Start()
    {
        rb.velocity = transform.right * projectileSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZoneL || transform.position.x > deadZoneR)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        Debug.Log(hit.name);
        if (hit.name != "Player")
        {
            Destroy(gameObject);
        }
            
    }
}
