using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObjectPatrolling : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public bool MoveBack;
    public NavMeshAgent Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveBack == true)
        {
            Object.SetDestination(pointA.position);
            if(!Object.pathPending)
            {
                if(Object.remainingDistance<= Object.stoppingDistance)
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
