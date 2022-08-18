using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushMovement : MonoBehaviour
{
    public Vector3 movementDirection = Vector3.left;

    private float rightBoundary = 4f;
    private float leftBoundary = -5f;
    private float topBoundary = 19f;
    private float bottomBoundary = 0f;

    void Start()
    {
        Time.fixedDeltaTime = 0.035f;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementDirection = Vector3.up; 
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movementDirection = Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movementDirection = Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movementDirection = Vector3.right;
        }


    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x + movementDirection.x), Mathf.Round(this.transform.position.y + movementDirection.y), -0.5f);

        if (this.transform.position.x >= rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }

        if (this.transform.position.x <= leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }

        if (this.transform.position.y >= topBoundary)
        {
            transform.position = new Vector3(transform.position.x, topBoundary, transform.position.z);
        }

        if (this.transform.position.y <= bottomBoundary)
        {
            transform.position = new Vector3(transform.position.x, bottomBoundary, transform.position.z);
        }
    }

}
