using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutCollider : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("PlayerRespawn");


        }

        if (other.gameObject.tag == "Opponent")
        {
            other.gameObject.transform.position = respawnPoint.transform.position;


        }



    }


    IEnumerator PlayerRespawn()
    {
        CharacterMovement.movementEnabled = false;
        yield return new WaitForSeconds(0.25f);
        player.transform.position = respawnPoint.transform.position;
        CharacterMovement.movementEnabled = true;
    }
}
