using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAreaRight : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.AddForce(Vector3.right * 200);
        }
    }


}
