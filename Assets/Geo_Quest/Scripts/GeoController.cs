using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string greet0 = "Hello";
    // int var = 3;
    private static float step = 0.005f;
    private Vector3 up = new Vector3(0, step, 0);
    private Vector3 down = new Vector3(0, -1 * step, 0);
    private Vector3 right = new Vector3(step, 0, 0);
    private Vector3 left = new Vector3(-1 * step, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        string greet1 = "World";
        Debug.Log(greet0 + " " + greet1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // wasd control
        {
            transform.position += up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += down;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += right;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += left;
        }
    }
}
