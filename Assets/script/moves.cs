using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{
    float h, v ;
    Rigidbody2D rb;
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal") * speed * Time.deltaTime; 
        v = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(h, v, 0);   
    }
}
