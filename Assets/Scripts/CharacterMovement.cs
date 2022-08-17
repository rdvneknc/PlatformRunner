using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float verticalSpeed;
    //public float horizontalSpeed;
    //public float maximumSpeed = 245;
    public float rotationSpeed;
    public Rigidbody rb;
    //public Vector3 move;
    public static bool movementEnabled = true;

    public Animator anim;

    public float maxVelocity; 

    // Start is called before the first frame update

    void Awake()
    {
        rb.GetComponent<Rigidbody>();

    }
    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));


        /*verticalSpeed += 0.5f * Time.deltaTime;

        if(verticalSpeed >= maximumSpeed)
        {
            verticalSpeed = maximumSpeed;
        }*/
    }

    void FixedUpdate()
    {
        /*if (movementEnabled == true)
        {
            rb.velocity = new Vector3(0, 0, 1) * verticalSpeed;
        }*/

           if (movementEnabled == true)
        {
            rb.AddForce(Vector3.forward * verticalSpeed);

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector3.right * rotationSpeed);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector3.left * rotationSpeed);
            }



        }

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);




        //move.x = Input.GetAxis("Horizontal") * horizontalSpeed;
        //move.z = Input.GetAxis("Vertical") * verticalSpeed;



        //Vector3 xMovement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        //rb.MovePosition(rb.position + move * verticalSpeed * Time.deltaTime);
    }

}
