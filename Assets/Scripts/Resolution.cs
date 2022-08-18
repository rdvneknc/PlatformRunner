using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    private void Awake()
    {

        Screen.SetResolution(564, 960, false);
        Screen.fullScreen = false;

    }
}
