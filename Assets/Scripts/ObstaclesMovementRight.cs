using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovementRight : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private float _duration;
    [SerializeField] private float _distanceRightMoving;

    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        
    }
}
