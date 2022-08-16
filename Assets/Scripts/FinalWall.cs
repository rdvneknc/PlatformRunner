using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWall : MonoBehaviour
{
    public Transform targetPosition;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
        }
    }
}
