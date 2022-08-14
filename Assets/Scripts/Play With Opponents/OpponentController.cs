using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class OpponentController : MonoBehaviour
{
    public Transform targetPosition;
    public NavMeshAgent navMeshAgent;

    private void Awake()
    {
        GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = targetPosition.position;
    }
}
