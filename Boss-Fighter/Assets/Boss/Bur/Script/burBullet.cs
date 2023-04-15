using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burBullet : MonoBehaviour
{
    [SerializeField] float horizontalDeadZone;
    [SerializeField] float verticalDeadZone;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * moveSpeed * Time.deltaTime;
        if (transform.position.x < horizontalDeadZone || transform.position.x > -1 * horizontalDeadZone)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < verticalDeadZone || transform.position.y > -1 * verticalDeadZone)
        {
            Destroy(gameObject);
        }
    }
}
