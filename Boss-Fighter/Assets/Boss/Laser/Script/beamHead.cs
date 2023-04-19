using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamHead : MonoBehaviour
{
    [SerializeField] private float timer;
    private int fireTime = 5;
    private int stopTime = 10;
    public Animator laserhead;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo animStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (animStateInfo.IsName("start1"))
        {
            laserhead.SetBool("endFire", false);
        }
        if (timer >= stopTime)
        {
            timer = 0;
            laserhead.SetBool("endFire", true);
        }


        timer += Time.deltaTime;
    }
}
