using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObstacle : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private Transform respawnPoint;

    [SerializeField] private Transform[] opponents;



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
        yield return new WaitForSeconds(2);
        player.transform.position = respawnPoint.transform.position;
        CharacterMovement.movementEnabled = true;
    }


}
