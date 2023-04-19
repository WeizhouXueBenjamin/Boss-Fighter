using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float timer;
    private int fireTime = 5;
    private int stopTime = 10;
    private int shootRange = 20;
    [SerializeField] private GameObject StartVFX;
    [SerializeField] private GameObject EndVFX;
    [SerializeField] private GameObject Beam;
    private LineRenderer lineRenderer;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        lineRenderer = GetComponentInChildren<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEndPosition();
        timer += Time.deltaTime;
    }
    private void UpdateEndPosition()
    {
        Vector3 startPosition = Beam.transform.position;
        float rotationZ = transform.rotation.eulerAngles.z; //degree
        rotationZ *= Mathf.Deg2Rad; //radian
        Vector3 direction = transform.right; //Calculate direction
        RaycastHit2D hit = Physics2D.Raycast(startPosition, direction.normalized); //Calculate hit point

        float length = shootRange;
        float laserEndRotation = 180;

        if (hit)
        {
            length = hit.distance;
            laserEndRotation = Vector2.Angle(direction, hit.normal); //particle reflection
        }

        if (timer >= stopTime)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            timer = 0;
        }

        else if (timer >= fireTime)
        {
            float set = 1.4f;
            transform.localScale = new Vector3(length / set, transform.localScale.y, transform.localScale.z);
        }

        Vector2 endPosition = startPosition + length * direction;
        EndVFX.transform.position = endPosition;
        EndVFX.transform.rotation = Quaternion.Euler(0, 0, -laserEndRotation);


    }
}
