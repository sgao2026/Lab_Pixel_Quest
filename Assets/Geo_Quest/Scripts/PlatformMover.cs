using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rb;
    private float _timeElapsed = 0f;
    public float TravelTime = 3f;
    public float speed = 10f;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _timeElapsed += Time.deltaTime;
        if (_timeElapsed > TravelTime)
        {
            _rb.velocity = _rb.velocity * new Vector2(-1f, 0f);
            _timeElapsed = 0f;
        } 
    }
}
