using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float speed;

    private Transform target;
    private int wayPointIndex;

    [SerializeField] private Transform player;

    [SerializeField] private Transform respawnPoint;

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

        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("PlayerRespawn");


        }

    }

    IEnumerator PlayerRespawn()
    {
        CharacterMovement.movementEnabled = false;
        yield return new WaitForSeconds(3);
        player.transform.position = respawnPoint.transform.position;
        CharacterMovement.movementEnabled = true;
    }

}
