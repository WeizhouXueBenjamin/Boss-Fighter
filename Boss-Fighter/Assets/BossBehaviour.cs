using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : StateMachineBehaviour
{
    [SerializeField] private int currtHealth;
    [SerializeField] private GameObject TuObject;
    [SerializeField] private GameObject cannon;
    [SerializeField] private float timer;
    [SerializeField] private float tuCoolDown;
    [SerializeField] private float CannonCoolDown;
    private GameObject tu;
    private GameObject _cannon;
    Transform tuStart;
    Transform cannonStart;
    private void Awake()
    {
        tuStart = GameObject.FindGameObjectWithTag("TuStart").transform;
        cannonStart = GameObject.FindGameObjectWithTag("CanonStart").transform;
    }
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Tu runtime
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("BossTu"))
        {
            tu = Instantiate(TuObject, tuStart.position, tuStart.rotation);
            animator.SetBool("StartTu", false);
            timer = 0;
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Cannon"))
        {
            GameObject cannonball = Instantiate(cannon, cannonStart.transform.position, Quaternion.identity);
            timer = 0;
            //animator.SetBool("StartCa")
        }
    }


    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        currtHealth = animator.GetComponent<BossHealth>().currentHealth;
        timer += Time.deltaTime;
        if (timer >= tuCoolDown && currtHealth > 50)
        {
            animator.SetBool("StartTu", true);
        }
        //Check if should change stage
        if (currtHealth < 50)
        {
            animator.SetBool("StartTu", false);
            animator.SetBool("StartCannon", true);
        }
        if (timer >= CannonCoolDown && currtHealth < 50)
        {
            animator.Play("Cannon", -1, 0f);
        }



    }


    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMachineEnter is called when entering a state machine via its Entry Node
    //override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}

    // OnStateMachineExit is called when exiting a state machine via its Exit Node
    //override public void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}
}
