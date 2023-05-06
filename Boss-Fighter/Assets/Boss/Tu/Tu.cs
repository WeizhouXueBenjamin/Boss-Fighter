using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tu : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] float speed;
    Vector2 endPoint;
    [SerializeField] int degrees;


    // Start is called before the first frame update
    void Start()
    {
        endPoint = new Vector2(Random.Range(transform.position.x - 10, transform.position.x), Random.Range(-7, 7));
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            timer = 0;
            endPoint = new Vector2(Random.Range(transform.position.x - 10, transform.position.x), Random.Range(-7, 7));
        }
        transform.position = Vector2.MoveTowards(transform.position, endPoint, speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, degrees * Time.deltaTime));
        if (transform.position.x <= -27)
        {
            Destroy(gameObject);
        }
    }
}
