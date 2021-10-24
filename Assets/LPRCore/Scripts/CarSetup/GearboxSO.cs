using System.Collections;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Gearbox", menuName = "ScriptableObjects/GearboxSO", order = 1)]
public class GearboxSO : ScriptableObject
{
    [SerializeField] private GearboxStruct[] gearboxStructs;

    public GearboxStruct[] GearboxStructs { get => gearboxStructs; }
}

[Serializable]
public struct GearboxStruct
{
    [SerializeField] private int minRPM;
    [SerializeField] private int maxRPM;
    [Tooltip(@" (gearRatio) engineRotate = 1 wheel rotate")]
    [SerializeField] private float gearRatio;

    public int MinRPM { get => minRPM; }
    public int MaxRPM { get => maxRPM; }
    public float GearRatio { get => gearRatio; }
}

