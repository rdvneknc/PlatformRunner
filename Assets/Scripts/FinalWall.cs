using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWall : MonoBehaviour
{
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
            var targetPos = startPosition + direction * lenght;
            float dist = Vector3.Distance(transform.position, targetPos);
            transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);
        }
    }

 




    
}
