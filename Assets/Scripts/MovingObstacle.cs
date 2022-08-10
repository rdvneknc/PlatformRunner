using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float speed;

    private Transform target;
    private int wayPointIndex;

    void Start()
    {
        target = WayPoints.wayPoints[0];
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            wayPointIndex++;
            target = WayPoints.wayPoints[wayPointIndex];

            if (wayPointIndex >= WayPoints.wayPoints.Length - 1)
            {
                wayPointIndex = -1;
            }
        }
  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.position = new Vector3(0, 1.22f, -36f);
            CharacterMovement.verticalSpeed = 250;
        }
        
    }

}
