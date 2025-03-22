using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private static float _step = 5f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal"); // horizontal movement
        _rb.velocity = new Vector2(xInput * _step, _rb.velocity.y); // using rigidbody calculated y movement
    }
}
