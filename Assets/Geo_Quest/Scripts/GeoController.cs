using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Unity.VisualScripting;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    // string greet0 = "Hello";
    public string nextLevel;
    // int var = 3;
    private static float step = 5f;
    //private Vector3 up = new Vector3(0, step, 0);
    //private Vector3 down = new Vector3(0, -1 * step, 0);
    //private Vector3 right = new Vector3(step, 0, 0);
    //private Vector3 left = new Vector3(-1 * step, 0, 0);

    private Rigidbody2D rb;
    private SpriteRenderer s;
    
    // Start is called before the first frame update
    void Start()
    {
        //string greet1 = "World";
        //Debug.Log(greet0 + " " + greet1);

        rb = GetComponent<Rigidbody2D>();
        s = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * step, rb.velocity.y);
        // rb.velocity = new Vector2(0, 0);
        // transform.position += direction;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Debug.Log("color red triggered");
            s.color = new Color(209f / 255, 46f / 255, 46f / 255, 1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Debug.Log("color green triggered");
            s.color = new Color(30f / 255, 158f / 255, 51f / 255, 1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Debug.Log("color blue triggered");
            s.color = new Color(75f / 255, 176f / 255, 227f / 255, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case ("Death"):
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    break;
                }
            case ("Finish"): 
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case ("Portal"):
                {
                    rb.gravityScale *= -1;
                    break;
                }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case ("Bounds"):
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    break;
                }
        }

    }
}
