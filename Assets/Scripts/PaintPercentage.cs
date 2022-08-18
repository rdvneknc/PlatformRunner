using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintPercentage : MonoBehaviour
{
    public static float percentage;
    public Text percentageText; 

    void Update()
    {
        percentageText.text = percentage.ToString() + "% PAINTED";
    }
}
