using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    private void Start()
    {
       Locator.Instance.Player.PointsChanged += HandlePlayerEarnedPoint; 
    }
    

}
