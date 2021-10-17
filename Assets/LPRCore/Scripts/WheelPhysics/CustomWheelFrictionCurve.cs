using System;
using UnityEngine;

[Serializable]
public struct CustomWheelFrictionCurve
{
    //
    // Summary:
    //     Extremum point slip (default 1).
    [SerializeField] private float extremumSlip;
    //
    // Summary:
    //     Force at the extremum slip (default 20000).
    [SerializeField] private float extremumValue;
    //
    // Summary:
    //     Asymptote point slip (default 2).
    [SerializeField] private float asymptoteSlip;
    // Summary:
    //     Force at the asymptote slip (default 10000).
    [SerializeField] private float asymptoteValue;
    // Summary:
    //     Multiplier for the extremumValue and asymptoteValue values (default 1).
    [SerializeField] private float stiffness;

    public float ExtremumSlip { get => extremumSlip; set => extremumSlip = value; }
    public float ExtremumValue { get => extremumValue; set => extremumValue = value; }
    public float AsymptoteSlip { get => asymptoteSlip; set => asymptoteSlip = value; }
    public float AsymptoteValue { get => asymptoteValue; set => asymptoteValue = value; }
    public float Stiffness { get => stiffness; set => stiffness = value; }
}
