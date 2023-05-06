using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawnerScript : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;
    [SerializeField] private float gunHeat;


    void Update()
    {
        if (gunHeat > 0)
        {
            gunHeat -= Time.deltaTime;
        }
        if (Input.GetButton("Fire1"))
        {
            if (gunHeat <= 0)
            {
                gunHeat = 0.25f;  // this is the interval between firing.
                Shoot();
            }
        }
    }
    void Shoot()
    {
        Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
    }


}
