using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scroll : MonoBehaviour
{
    private float spriteWidth; 
    float speed = 2.5f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();
        spriteWidth = groundCollider.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -spriteWidth)
        {
            SceneManager.LoadSceneAsync(0);
            ResetPosition();
        }
    }
      
     void ResetPosition()
     {
        transform.Translate(new Vector3(0f, 300 * spriteWidth, 0f));
     }
}
