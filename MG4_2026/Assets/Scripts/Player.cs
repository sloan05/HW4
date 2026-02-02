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
        if (_rigibody == null)
        {
            _rigibody = GetComponant<Rigibody2D>();
        }
    }

    
    void Update()
    {
        if (Input.GetKey(KeycCode.Space))
        {
            _rigibody.velocity = new Vector2 (_rigibody.velocity.x, _jumpVelocity);
        }
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
         if (other.CompareTag("Pipe"))
        {
            Debug.Log("DIES");
            _Locator.ResetPoints();
            Destory(other.GameObject);
        }

        if (other.CompareTag("InvisibleWall"))
        {
            Debug.Log("PointScored!");
            _Locator.AddPoint();
        }
    
    }
   
    
}
