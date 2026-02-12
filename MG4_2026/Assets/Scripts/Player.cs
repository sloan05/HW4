using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bird : MonoBehaviour
{
    public event Action<int> PointsChanged;
    [SerializeField] public float _jumpVelocity = 5f;
    

    [SerializeField] private Rigidbody2D _rb;

    

    private int _points = 0;


    
    void Start()
    {
        if (_rb == null)
        {
            _rb = GetComponent<Rigidbody2D>();

            PointsChanged?.Invoke(_points);
        }
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = new Vector2 (_rb.velocity.x, _jumpVelocity);
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
         if (collision.gameObject.CompareTag("Pipe"))
        {
            _points = 0;
            PointsChanged?.Invoke(_points);
        }
    
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("InvisibleWall"))
        {
            _points++;
            PointsChanged?.Invoke(_points);
        }
    }
   
    
}
