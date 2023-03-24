using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpHeight = 50;
    public float moveSpeed = 20;
    //public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 1 * jumpHeight);
        }
        Debug.Log(transform.position.x);
    }

    public void playerMove()
    {
        
    }
}
