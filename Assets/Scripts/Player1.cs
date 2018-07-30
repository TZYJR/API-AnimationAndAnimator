using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Player1 : MonoBehaviour
{

    public NavMeshAgent Agent;
    public Animation animation;
    //public Animator animator;


    private Ray ray;
    private RaycastHit raycastHit;
    private float magnitude;

    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool isRaycast = Physics.Raycast(ray, out raycastHit, 100);
        if (isRaycast && Input.GetMouseButtonDown(1))
        {
            Agent.SetDestination(raycastHit.point);
        }

        //animator.SetFloat("run", Agent.velocity.magnitude);

        magnitude = Agent.velocity.magnitude;

        if (magnitude <= 0.1f && magnitude >= 0)
        {
            animation.CrossFade("BG_Idle");
        }
        else if (magnitude > 0.1f && magnitude <= 2.0f)
        {
            animation.CrossFade("BG_Walk");
        }
        else if (magnitude > 2.0f)
        {
            animation.CrossFade("BG_Run");
        }



        if (Input.GetMouseButton(0))
        {
            animation.CrossFade("BG_PutBlade");
        }


        if (Input.GetKey(KeyCode.Q))
        {
            animation.CrossFade("BG_RunAttack");
        }
        if (Input.GetKey(KeyCode.W))
        {
            animation.CrossFade("BG_Skill");
        }
        if (Input.GetKey(KeyCode.E))
        {
            animation.CrossFade("BG_L_Avoid");
        }
        if (Input.GetKey(KeyCode.R))
        {
            animation.CrossFade("BG_Kick");
        }
        if (Input.GetKey(KeyCode.F))
        {
            animation.CrossFade("BG_Death");
        }
        if (Input.GetKey(KeyCode.A))
        {
            animation.CrossFade("BG_Combo1_3");
        }
        if (Input.GetKey(KeyCode.S))
        {
            animation.CrossFade("BG_Combo1_2");
        }
        if (Input.GetKey(KeyCode.D))
        {
            animation.CrossFade("BG_Combo1");
        }



        if (Input.GetKey(KeyCode.Alpha1))
        {
            animation.CrossFade("BG_Talk01");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            animation.CrossFade("BG_Talk");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            animation.CrossFade("BG_GangnamStyle");
        }

    }

}  
