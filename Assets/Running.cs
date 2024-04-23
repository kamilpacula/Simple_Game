using UnityEngine;
using UnityEngine.AI;

public class Running : StateMachineBehaviour
{
    private NavMeshAgent agent;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Pobierz komponent NavMeshAgent tylko raz, aby uniknąć zbędnych wywołań
        if (agent == null)
        {
            agent = animator.GetComponent<NavMeshAgent>();
        }

        // Sprawdź, czy agent jest aktywny i umieszczony na NavMesh przed wywołaniem ResetPath
        if (agent != null && agent.isActiveAndEnabled && agent.isOnNavMesh)
        {
            agent.ResetPath();
        }

        // Sprawdź, czy agent jest aktywny i umieszczony na NavMesh przed wywołaniem SetDestination
        if (agent != null && agent.isActiveAndEnabled && agent.isOnNavMesh)
        {
            // Tutaj umieść swoją docelową pozycję (Vector3) dla SetDestination
            Vector3 targetPosition = new Vector3(0f, 0f, 0f); // Zastąp tym swoją docelową pozycją
            agent.SetDestination(targetPosition);
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
