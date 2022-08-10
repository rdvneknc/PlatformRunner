using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    //private float startDelay = 5;
    //private float repeatTiming = 10;

    public Rigidbody donutRb;


    private void Awake()
    {
        donutRb.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        //InvokeRepeating("MoveTheStick", startDelay, repeatTiming);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StickMovement());
    }

    IEnumerator StickMovement()
    {
        //donutRb.AddForce(Vector3.left * 500, ForceMode.Impulse);
        yield return new WaitForSeconds(3);

        donutRb.velocity = new Vector3(-30, transform.position.y, transform.position.z);
        //donutRb.MovePosition(new Vector3(-1, 0, 0));

        yield return new WaitForSeconds(5);



        //donutRb.velocity = new Vector3(-30, transform.position.y, transform.position.z);

        //transform.Translate(new Vector3(-5.5f, 0, 0));

        //transform.Translate(new Vector3(5.5f, 0, 0));

    }
}
