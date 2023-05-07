using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    [SerializeField] Vector3 instantForce;
    [SerializeField] Vector3 continuousForce;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
        Vector2 aimPoint = new Vector2(Random.Range(-10, -20), Random.Range(10, 4) * 5);
        //transform.LookAt(aimPoint);
        rigidbody2d.velocity = aimPoint;


    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody2d.velocity = -rigidbody2d.transform.right * speed;

        fire();
    }
    private void fire()
    {
        //rigidbody2d.AddForce(continuousForce, ForceMode2D.Impulse);
        rigidbody2d.AddForce(-rigidbody2d.transform.right * 5, ForceMode2D.Force);
    }
}
