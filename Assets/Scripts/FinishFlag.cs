using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishFlag : MonoBehaviour
{

    public static bool levelOneEnded = false;
    public static bool levelThreeEnded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("StopPlayerMovement");
        }

        if (other.gameObject.tag == "Opponent")
        {
            levelThreeEnded = true;
        }
    }

    IEnumerator StopPlayerMovement()
    {
        yield return new WaitForSeconds(1);
        levelOneEnded = true;
        CharacterMovement.movementEnabled = false;
              
    }


}
