using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTracking : MonoBehaviour
{
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;
    private float timer = 0;
    private float aimTime = 2.5f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 4 * aimTime)
        {
            timer = 0;
        }
        else if (timer <= aimTime - 1)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;

        }

    }
}
