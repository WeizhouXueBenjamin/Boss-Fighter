using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    Animator animator;
    [SerializeField] private GameObject blockLaser;
    [SerializeField] private GameObject blocker;
    [SerializeField] private int coolDown;
    [SerializeField] private float timer;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float deadZone;
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        animator = blockLaser.GetComponent<Animator>();
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= coolDown)
        {
            animator.SetBool("start", true);
        }
        if (transform.position.x < deadZone || currentHealth <= 0)
        {
            Destroy(gameObject);
            Destroy(blocker.gameObject);
        }
        transform.localPosition -= (Vector3.right * moveSpeed) * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            currentHealth -= 1;
            Destroy(other.gameObject);
        }
    }
}
