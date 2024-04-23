using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : StateMachineBehaviour
{
    private UnityEngine.AI.NavMeshAgent _nav;
    private Transform _player;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _nav = animator.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Sprawdź, czy agent jest aktywny i umieszczony na NavMesh przed wywołaniem SetDestination
        if (_nav != null && _nav.isActiveAndEnabled && _nav.isOnNavMesh)
        {
            _nav.SetDestination(_player.position);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    // Uncomment and implement if needed
    // override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    // {
    //     // Additional logic when exiting the state
    // }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    // Uncomment and implement if needed
    // override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    // {
    //     // Implement code that processes and affects root motion
    // }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    // Uncomment and implement if needed
    // override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    // {
    //     // Implement code that sets up animation IK (inverse kinematics)
    // }
}