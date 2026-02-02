using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] public float _jumpVelocity = 5f;
    [SerializeField] private transform _playerTransform;

    [SerializeField] private Rigidbody2D rigidbody;


    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeycCode.Space))
        {
            _rigibody.velocity = new Vector2 (_rigibody.velocity.x, _jumpVelocity);
        }
    }
}
