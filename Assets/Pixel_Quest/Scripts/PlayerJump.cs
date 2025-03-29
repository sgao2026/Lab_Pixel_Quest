using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float JumpForce = 5f;

    // Capsule
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;

    // Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;

    // forces
    public float jumpForce = 10;
    public float fallForce = 2;
    private Vector2 _gravityVector;

    // water
    private bool _waterCheck;

    // Start is called before the first frame update
    void Start()
    {
        _gravityVector = new Vector2(0, Physics2D.gravity.y);
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Vertical, 0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) && (_groundCheck || _waterCheck))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, JumpForce);
        }

        if (_rb.velocity.y < 0 && !_waterCheck)
        {
            _rb.velocity += _gravityVector * (fallForce * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Water")) { _waterCheck = true; }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Water")) { _waterCheck = false; }
    }
}
