using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionUp : MonoBehaviour
{
    public GameObject positionDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "PlayerPosition")
        {
            positionDisplay.GetComponent<Text>().text = "1st";
        }
    }
}
