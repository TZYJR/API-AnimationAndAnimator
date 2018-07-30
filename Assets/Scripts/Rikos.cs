using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Rikos : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Animator animator;

    Ray ray;
    RaycastHit raycasHit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool isRaycast = Physics.Raycast(ray, out raycasHit, 100);
        if (isRaycast && Input.GetMouseButtonDown(1))
        {
            Agent.SetDestination(raycasHit.point);
        }
        animator.SetFloat("Switch", Agent.velocity.magnitude);
    }
}
