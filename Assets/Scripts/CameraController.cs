using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform player;

    private float offsetY = 15f;
    private float offsetZ = -13f;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }


    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y + offsetY, player.position.z + offsetZ);
    }
}
