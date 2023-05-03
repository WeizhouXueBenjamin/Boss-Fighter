using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;
    public float maxPlayerHealth = 100;
    // private int nextUpdate=1; // Testing

    void Start()
    {
        playerHealth = maxPlayerHealth;
    }

    void Update()
    {
        // if (Time.time>nextUpdate) // Testing
        // {
        //     nextUpdate = Mathf.FloorToInt(Time.time)+1;
        //     playerHealth -= 10;
        // }
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("YouDied");
        }
    }

    public void takeHit(float damage) 
    {
        playerHealth -= damage;
        
    }
    
}
