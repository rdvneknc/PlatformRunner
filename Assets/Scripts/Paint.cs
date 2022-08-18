using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public bool painted = false;
    
    public Material whiteColor;
    public Material redColor;

    public Transform brush;


    //public Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material = whiteColor;


    }

    // Update is called once per frame
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
