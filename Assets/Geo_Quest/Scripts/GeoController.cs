using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string greet0 = "Hello";
    int var = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        string greet1 = "World";
        Debug.Log(greet0 + " " + greet1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var);
        Debug.Log(transform.position);
        var++;
    }
}
