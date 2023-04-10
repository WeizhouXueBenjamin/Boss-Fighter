using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float timer;
    private int fireTime = 5;
    private int stopTime = 10;
    private int shootRange = -20;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= stopTime)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            timer = 0;
        }

        else if (timer >= fireTime)
        {

            transform.localScale = new Vector3(shootRange, transform.localScale.y, transform.localScale.z);
        }
        timer += Time.deltaTime;
    }
}
