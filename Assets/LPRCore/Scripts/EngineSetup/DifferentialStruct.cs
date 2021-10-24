using System.Collections;
using System;
using UnityEngine;

[Serializable]
public struct DifferentialStruct
{
    
    [SerializeField] private WheelBehavoiur leftWheel;
    [SerializeField] private WheelBehavoiur rightWheel;

    public WheelBehavoiur LeftWheel { get => leftWheel; set => leftWheel = value; }
    public WheelBehavoiur RightWheel { get => rightWheel; set => rightWheel = value; }
}
