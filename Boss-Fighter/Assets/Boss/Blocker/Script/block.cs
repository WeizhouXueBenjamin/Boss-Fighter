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
    [SerializeField] private int blockHealth;

    // Start is called before the first frame update
    void Start()
    {
        animator = blockLaser.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= coolDown)
        {
            animator.SetBool("start", true);
        }
        if (transform.position.x < deadZone || blockHealth <= 0)
        {
            Destroy(gameObject);
            Destroy(blocker.gameObject);
        }
        transform.localPosition -= (Vector3.right * moveSpeed) * Time.deltaTime;
    }
}
