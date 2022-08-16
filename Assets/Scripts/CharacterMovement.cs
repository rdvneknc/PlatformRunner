using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public  float verticalSpeed = 240;
    //public float horizontalSpeed;
    public float maximumSpeed = 245;

    public Rigidbody rb;
    //public Vector3 move;
    public static bool movementEnabled = true;

    public Animator anim;

    // Start is called before the first frame update

    void Awake()
    {
        rb.GetComponent<Rigidbody>();

    }
    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));


        verticalSpeed += 0.5f * Time.deltaTime;

        if(verticalSpeed >= maximumSpeed)
        {
            verticalSpeed = maximumSpeed;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.velocity = new Vector3(0, 0, 5) * verticalSpeed;

        if (movementEnabled == true)
        {
            rb.AddForce(Vector3.forward * verticalSpeed);

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector3.right * 300);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector3.left * 300);
            }

            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * 500);
            }
        }
        
        




        //move.x = Input.GetAxis("Horizontal") * horizontalSpeed;
        //move.z = Input.GetAxis("Vertical") * verticalSpeed;



        //Vector3 xMovement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        //rb.MovePosition(rb.position + move * verticalSpeed * Time.deltaTime);
    }

}
