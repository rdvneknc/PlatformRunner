using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float verticalSpeed;
    public float rotationSpeed;

    public Rigidbody rb;

    public static bool movementEnabled = true;

    public Animator anim;

    public float maxVelocity; 

    void Awake()
    {
        rb.GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {

           if (movementEnabled == true)
        {
            rb.AddForce(Vector3.forward * verticalSpeed);

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector3.right * rotationSpeed * Time.fixedTime);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector3.left * rotationSpeed * Time.fixedTime);
            }



        }

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);

    }

}
