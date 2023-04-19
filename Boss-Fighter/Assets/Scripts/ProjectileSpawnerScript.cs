using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawnerScript : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
    }
}
