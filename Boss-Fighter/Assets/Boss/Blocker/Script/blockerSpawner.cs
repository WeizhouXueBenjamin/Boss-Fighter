using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class blockerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject blocker;
    [SerializeField] private float timer;
    [SerializeField] private float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawner();
            timer = 0;
        }


    }
    void spawner()
    {
        Instantiate(blocker, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }
}
