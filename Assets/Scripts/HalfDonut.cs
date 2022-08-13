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



    private void Awake()
    {
        //donutRb.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //donutRb.AddForce(Vector3.left * 500, ForceMode.Impulse);

        //InvokeRepeating("StickMovement", startDelay, repeatTiming);
    }

    // Update is called once per frame
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
        
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(3);
        transform.position = Vector3.Lerp(transform.position, target2.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(3);
        moveHalfDonut = false;
        


    }
}
