using System.Collections;
using System;
using UnityEngine;

[Serializable]
public struct WheelValuesInCarBoby
{
    [SerializeField] private Transform targetPosition;
    [SerializeField] private float maxRadius;
    [SerializeField] private float minRadius;
    [SerializeField] private float minWight;
    [SerializeField] private float maxWight;

    public Transform TargetPosition { get => targetPosition; set => targetPosition = value; }
    public float MaxRadius { get => maxRadius; set => maxRadius = value; }
    public float MinRadius { get => minRadius; set => minRadius = value; }
    public float MinWight { get => minWight; set => minWight = value; }
    public float MaxWight { get => maxWight; set => maxWight = value; }
    
}
