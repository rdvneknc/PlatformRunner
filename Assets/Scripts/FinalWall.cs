using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWall : MonoBehaviour
{
    public Transform targetPosition;
    public float speed;


    void Update()
    {
        if (FinishFlag.levelEnded == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
            
        }
    }

  
}
