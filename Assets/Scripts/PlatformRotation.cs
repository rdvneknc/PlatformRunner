using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotation : MonoBehaviour
{
    public float speed;
 

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime * speed);
    }

   

}
