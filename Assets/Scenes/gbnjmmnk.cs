using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gbnjmmnk : MonoBehaviour
{
    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector2(0, 0);
         if(Input.GetKey(KeyCode.RightArrow))  
        {
            Rb.velocity = new Vector2(10, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Rb.velocity = new Vector2(-10, 0);         
        }
    }
}
