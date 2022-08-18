using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWall : MonoBehaviour
{
    //public Transform targetPosition;
    public float speed;

    public float lenght;

    public Vector3 direction;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }


    void Update()
    {
        if (FinishFlag.levelEnded == true)
        {
            //transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);

            var targetPos = startPosition + direction * lenght;
            float dist = Vector3.Distance(transform.position, targetPos);
            transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);

        }
    }

 




    
}
