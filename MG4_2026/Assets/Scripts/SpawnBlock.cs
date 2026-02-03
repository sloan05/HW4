using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab;
    [SerializeField] private float _spawnInterval = 2f;

    private float _timer;

    private void Start()
    {
        SpawnPipe();
    }
    
    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer >= _spawnInterval)
        {
            SpawnPipe();
            _timer = 0f;
        }
    }

    public void SpawnPipe()
    {
        GameObject newPipe = Instantiate(_pipePrefab);
        newPipe.transform.position = transform.position;

        Debug.Log("Spawned pipe!");
    }
}
