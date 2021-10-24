using System.Collections;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "EngineType", menuName = "ScriptableObjects/EngineSO", order = 1)]
public class EngineDataSO : ScriptableObject
{
    [SerializeField] private int maxEngineRPM = 2500;
    [SerializeField] private int minimumRPM = 1000;
    [SerializeField] private AnimationCurve torqueCurve;
    [SerializeField] private CylinderEnum cylinderValue;
    [SerializeField] private AudioClip engineSound;
    [SerializeField] private EngineBehavior enginePrefab;


    public int MaxEngineRPM { get => maxEngineRPM; }
    public AnimationCurve TorqueCurve { get => torqueCurve; }
    public CylinderEnum CylinderValue { get => cylinderValue; }
    public AudioClip EngineSound { get => engineSound; }
    public EngineBehavior EnginePrefab { get => enginePrefab; }
    public int MinimumRPM { get => minimumRPM; }
}
