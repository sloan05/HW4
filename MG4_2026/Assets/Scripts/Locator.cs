using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    private int _score = 0;

    private void Start()
    {
       Locator.Instance.Player.PointsChanged += HandlePlayerEarnedPoint; 

       UpdateScoreUI();
    }


    public void AddPoint()
    {
        _score++;
        UpdateScoreU();
    }
    
    private void UpdateScoreU()
    {
        if (_scoreText != null)
        {
            _scoreText.text = _score;
        }
    }

}
