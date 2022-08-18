using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishFlag : MonoBehaviour
{

    public static bool levelEnded;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("StopPlayerMovement");
        }
    }

    IEnumerator StopPlayerMovement()
    {
        yield return new WaitForSeconds(1);
        CharacterMovement.movementEnabled = false;
        levelEnded = true;        
    }


}
