using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]

public class WatchPoints : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
    private int i = 0;
    private bool canWatch = true;
    public List<Transform> patrolPoints;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = patrolPoints[i];
        canWatch = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        canWatch = false;
        destination = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        canWatch = true;
    }

    private void Update()
    {
      agent.destination = destination.position;
            if (!canWatch) return;
            if (agent.pathPending || !(agent.remainingDistance < 0.5f)) return;
            destination = patrolPoints[i];
            i = (i + 1) % patrolPoints.Count;
    }
}
