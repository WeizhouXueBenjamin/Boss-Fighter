using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bur : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] GameObject bullet;
    [SerializeField] float coolDown;
    Animator animator;
    private bool trigger = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (trigger == true && timer > coolDown)
        {
            trigger = false;
            animator.SetBool("blowUp", true);
            blowUp();
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("end"))
        {
            Destroy(gameObject);
        }
    }

    private void blowUp()
    {
        for (int i = 0; i < 8; i++)
        {
            Vector3 newRotation = new Vector3(0, 0, i * 45);
            bullet.transform.eulerAngles = newRotation;
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }
    }
}
