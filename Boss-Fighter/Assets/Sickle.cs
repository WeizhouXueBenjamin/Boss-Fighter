using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sickle : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float tuning;
    [SerializeField] private Vector2 startSpeed;
    [SerializeField] private float horizontalDeadZone;
    private Transform playerTransform;
    private Transform sickleTransform;
    private Rigidbody2D rigidbody2d;
    private CameraShake camShake;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = -transform.right * speed;
        startSpeed = rigidbody2d.velocity;

        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sickleTransform = GetComponent<Transform>();
        camShake = GameObject.FindGameObjectWithTag("CameraShake").GetComponent<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2d.velocity -= startSpeed * Time.deltaTime;
        if (transform.position.x > horizontalDeadZone || transform.position.x < -horizontalDeadZone)
        {
            Destroy(gameObject);
        }
    }
}
