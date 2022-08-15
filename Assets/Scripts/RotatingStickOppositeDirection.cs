using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingStickOppositeDirection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            CharacterMovement.movementEnabled = false;


        }
    }


}
