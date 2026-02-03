using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private float _movespeed = 7f;

    [SerializeField] private float _minY = -1.5f;
    [SerializeField] private float _maxY = 1.5f;

    private void Start()
    {
        float randomOffsetY = Random.Range(_minY, _maxY);
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y + randomOffsetY,
            transform.position.z
        );
    }
    void Update()
    {
        transform.Translate(Vector3.left * _movespeed * Time.deltaTime);
    }
}
