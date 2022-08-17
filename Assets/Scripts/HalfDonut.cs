using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    //private float startDelay = 2;
    //private float repeatTiming = 12;

    public Transform target;
    public Transform target2;
    public float speed;

    public bool moveHalfDonut = false;


    void Update()
    {
        
        if(moveHalfDonut == false)
        {
            moveHalfDonut = true;
            StartCoroutine(StickMovement());
        }
        
    }

    IEnumerator StickMovement()
    {
        
        transform.position = Vector3.Lerp(transform.position, target.position, speed);
        yield return new WaitForSeconds(4);
        transform.position = Vector3.Lerp(transform.position, target2.position, speed);
        yield return new WaitForSeconds(4);
        moveHalfDonut = false;
        


    }
}
