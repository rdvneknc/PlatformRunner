using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public bool painted = false;
    
    public Material whiteColor;
    public Material redColor;

    public Transform brush;


    void Awake()
    {
        gameObject.GetComponent<Renderer>().material = whiteColor;

    }

    void Update()
    {
        if(painted == false)
        {
            if (this.transform.position.x == brush.transform.position.x && this.transform.position.y == brush.transform.position.y)
            {
                gameObject.GetComponent<Renderer>().material = redColor;

                PaintPercentage.percentage += 0.5f;

                painted = true;

            }
        }
        
        
    }

}
