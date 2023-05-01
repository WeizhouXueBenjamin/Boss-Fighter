using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : StateMachineBehaviour
{
    [SerializeField] private GameObject TuObject;
    [SerializeField] private float timer;
    [SerializeField] private float tuCoolDown;
    private GameObject tu;
    Transform tuStart;
    private void Awake()
    {
        tuStart = GameObject.FindGameObjectWithTag("TuStart").transform;
    }
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("BossTu"))
        {
            tu = Instantiate(TuObject, tuStart.position, tuStart.rotation);
            animator.ResetTrigger("Tu");
            timer = 0;
        }
    }


    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        if (timer >= tuCoolDown)
        {
            animator.SetTrigger("Tu");
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
