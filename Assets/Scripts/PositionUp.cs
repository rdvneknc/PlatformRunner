using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionUp : MonoBehaviour
{
    public GameObject positionDisplay;


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "PlayerPosition")
        {
            positionDisplay.GetComponent<Text>().text = "1st";
        }
    }
}
