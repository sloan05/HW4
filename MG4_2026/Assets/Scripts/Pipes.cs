using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private float _movespeed = 7f;
    void Update()
    {
        transform.Translate(Vector3.left * _movespeed * Time.deltaTime);
    }
}
