using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;
    public float maxPlayerHealth = 100;

    void Start()
    {
        playerHealth = maxPlayerHealth;
    }

    public void takeHit(float damage) 
    {
        playerHealth -= damage;
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("YouDieMenu");
        }
    }
    
}
