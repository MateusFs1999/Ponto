using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingBehaviour : StateMachineBehaviour {

    private Transform playerPos;
    private Transform Tubalão;
    public float speed;
    
	 
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        Tubalão = GameObject.FindGameObjectWithTag("Tubalão").transform;
	}

	
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.transform.position = Vector2.MoveTowards(animator.transform.position,playerPos.position,speed*Time.deltaTime);

         Vector2.Distance(animator.transform.position, playerPos.position);

        if (Vector2.Distance(Tubalão.position,playerPos.position) > 25)
        {
            animator.SetBool("IsFollowing", false);
        }
    }

	
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
