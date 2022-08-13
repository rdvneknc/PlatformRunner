using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingStick : MonoBehaviour
{


    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(new Vector3(0, -60, 0) * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.AddForce(Vector3.back * 30000);
        }
    }


}
