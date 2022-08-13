using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour

{
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(0, 1.22f, -35);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = startPosition;
        }
    }
}
