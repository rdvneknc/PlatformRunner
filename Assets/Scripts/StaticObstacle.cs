using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            new WaitForSeconds(3);
            other.transform.position = new Vector3(0, 1.22f, -36f);
            CharacterMovement.verticalSpeed = 250;
        }

    }
}
