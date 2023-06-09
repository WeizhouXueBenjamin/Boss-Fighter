using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] public int currentHealth;
    [SerializeField] private GameObject pausePanel;
    CameraShake cameraShake;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        cameraShake = GameObject.FindGameObjectWithTag("CameraShake").GetComponent<CameraShake>();
    }

    // Update is called once per frame
    void update()
    {
        if (currentHealth <= 0)
        {

        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            takeDamage(1);
            Destroy(other.gameObject);
        }
    }
    void takeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("YouWin");
        }
    }
}
