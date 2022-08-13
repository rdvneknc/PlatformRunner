using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float brushSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(20,0,0));

            
        }*/
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //rb.MovePosition(new Vector3(9, rb.transform.position.y, rb.transform.position.z));

            //rb.velocity = new Vector3(9, 0, 0) * brushSpeed;

            rb.AddForce(Vector3.right * 5);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //rb.MovePosition(new Vector3(9, rb.transform.position.y, rb.transform.position.z));

            //rb.velocity = new Vector3(9, 0, 0) * brushSpeed;

            rb.AddForce(Vector3.left * 5);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //rb.MovePosition(new Vector3(9, rb.transform.position.y, rb.transform.position.z));

            //rb.velocity = new Vector3(9, 0, 0) * brushSpeed;

            rb.AddForce(Vector3.up * 5);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //rb.MovePosition(new Vector3(9, rb.transform.position.y, rb.transform.position.z));

            //rb.velocity = new Vector3(9, 0, 0) * brushSpeed;

            rb.AddForce(Vector3.down * 5);
        }
    }
}
