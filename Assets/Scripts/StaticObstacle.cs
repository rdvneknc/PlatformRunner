using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObstacle : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private Transform respawnPoint;

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
            StartCoroutine("PlayerRespawn");
            

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
