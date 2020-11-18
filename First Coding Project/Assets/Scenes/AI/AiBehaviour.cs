using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AiBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
    private int i = 0;
    private bool canPatrol = true;
    public List<Transform> patrolPoints;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        canPatrol = false;
        destination = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        canPatrol = true;
    }

    private void Update()
    {
        agent.destination = destination.position;
        if (!canPatrol) return;

        if (agent.pathPending && agent.remainingDistance<0.5f)
        {
            destination = patrolPoints[1];
            i = (i + 1) % patrolPoints.Count;
        }
    }
}
