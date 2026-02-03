using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Locator : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private Bird _player;

    

    private void Start()
    {
        if (_player != null)
        {
            _player.PointsChanged += HandlePointsChanged;
        }
        
    }
    private void HandlePointsChanged(int points)
    {
        if(_scoreText != null)
        {
            _scoreText.text = points.ToString();
        }
    }


}
