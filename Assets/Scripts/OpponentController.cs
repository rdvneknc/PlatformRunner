using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class OpponentController : MonoBehaviour
{
    public Transform targetPosition;
    //public NavMeshAgent navMeshAgent;

    private NavMeshPath path;
    private int pathIndex;

    public float moveSpeed = 10;
    public float rotateSpeed = 10;

    public float calculateInterval = 10;

    private float time;
    private bool movementEnabled = true;

    private void Awake()
    {
        path = new NavMeshPath();
        //GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (movementEnabled == true)
        {
            time += Time.deltaTime;

            if (1.0f / calculateInterval < time)
            {
                if (NavMesh.CalculatePath(transform.position, targetPosition.position, NavMesh.AllAreas, path))
                {
                    pathIndex = 1;
                }

                time = 0;
            }

            if (path.corners.Length > 0)
            {
                Vector3 cornerPos = path.corners[pathIndex];

                float dist = Vector3.Distance(cornerPos, transform.position);
                transform.position = Vector3.MoveTowards(transform.position, cornerPos, moveSpeed * Time.deltaTime);

                Vector3 diff = cornerPos - transform.position;
                diff.y = 0;

                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(diff), rotateSpeed * Time.deltaTime);

                if (dist < 0.1f)
                {
                    pathIndex++;
                }
            }
        }


        //navMeshAgent.SetDestination(new Vector3(targetPosition.transform.position));
    }


}
