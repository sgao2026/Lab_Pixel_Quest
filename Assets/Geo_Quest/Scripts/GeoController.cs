using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string greet0 = "Hello";
    // int var = 3;
    private static float step = 2f;
    //private Vector3 up = new Vector3(0, step, 0);
    //private Vector3 down = new Vector3(0, -1 * step, 0);
    //private Vector3 right = new Vector3(step, 0, 0);
    //private Vector3 left = new Vector3(-1 * step, 0, 0);

    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        //string greet1 = "World";
        //Debug.Log(greet0 + " " + greet1);

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 direction = new Vector3(0, 0, 0);
        /* if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) // wasd + arrow keys control
        {
            // direction += up;
            rb.velocity = new Vector2(rb.velocity.x, step);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            // direction += down;
            rb.velocity = new Vector2(rb.velocity.x, -1 * step);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // direction += right;
            rb.velocity = new Vector2(step, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // direction += left;
            rb.velocity = new Vector2(-1 * step, rb.velocity.y);
        } */

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical") == 0 ? rb.velocity.y : Input.GetAxis("Vertical") * step;
        rb.velocity = new Vector2(xInput * step, yInput);
        // rb.velocity = new Vector2(0, 0);
        // transform.position += direction;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case ("Death"):
                {
                    Debug.Log("Player Has Died");
                    break;
                }
        }
    }
}
