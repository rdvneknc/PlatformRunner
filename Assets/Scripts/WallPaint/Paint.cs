using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    //public Material wallMaterial;

    public Renderer render;

    public Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Material>();

        //render.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Brush")
        {
            render.material.color = defaultColor;

        }
    }
}
