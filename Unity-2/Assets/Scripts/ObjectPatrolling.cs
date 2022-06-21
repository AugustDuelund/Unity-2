using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObjectPatrolling : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public bool MoveBack;

    //Chess piece with NavMeshAgent 
    public NavMeshAgent Object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //This function runs the else statement first.
    //Updates the movement of the patrolling object and tells it which point to travel towards.
    void Update()
    {
        if(MoveBack == true)
        {
            Object.SetDestination(pointA.position);
            if(!Object.pathPending)
            {
                if(Object.remainingDistance<= Object.stoppingDistance) //is called when it reaches the stopping distance.
                {
                    Object.SetDestination(pointB.position);
                    MoveBack = false;
                }
            }
        }
        else
        {
            Object.SetDestination(pointB.position);
            if(!Object.pathPending)
            {
                if(Object.remainingDistance <= Object.stoppingDistance)
                {
                    MoveBack = true;
                }
            }
        }
    }
}
