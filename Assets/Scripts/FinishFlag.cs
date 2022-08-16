using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishFlag : MonoBehaviour
{
    //public Rigidbody playerRb;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            StartCoroutine("StopPlayerMovement");
            //CharacterMovement.movementEnabled = false;

        }

    }

    IEnumerator StopPlayerMovement()
    {
        yield return new WaitForSeconds(1f);
        CharacterMovement.movementEnabled = false;
        
        //playerRb.isKinematic = true;

    }


}
