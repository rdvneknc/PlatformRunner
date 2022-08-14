using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent nav;
    private Vector3 targetDir;
    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.FindGameObjectsWithTag("Finish").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        targetDir = target.position - transform.position;
        float _angle = (Vector3.Angle(targetDir, transform.forward));

        if(_angle >= -70 && _angle <= 70)
        {
            nav.SetDestination(target.position);
        }
    }
}
