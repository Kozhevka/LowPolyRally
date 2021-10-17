using System;
using UnityEngine;


[Serializable]
public struct ColorStruct
{

    [SerializeField] private string colorCode;
    [SerializeField] private Vector3 colorRGB; 
    [SerializeField] private Color color;
    [SerializeField] private ColorEnum colorEnum;

    [Header("Desctiptions and values")]
    [SerializeField] private string materialName;
    [SerializeField] private CustomWheelFrictionCurve forwardFrictionCurve;
    [SerializeField] private CustomWheelFrictionCurve sideFrictionCurve;
    [SerializeField] private float bouncyValue;
    




    public string ColorCode { get => colorCode;  private set => colorCode = value; }
    public Vector3 ColorRGB { get => colorRGB; private set => colorRGB = value; }
    public Color Color { get => color; private set => color = value; }
    public string MaterialName { get => materialName; private set => materialName = value; }
    public CustomWheelFrictionCurve ForwardFrictionCurve { get => forwardFrictionCurve; private set => forwardFrictionCurve = value; }
    public CustomWheelFrictionCurve SideFrictionCurve { get => sideFrictionCurve; private set => sideFrictionCurve = value; }
    public float BouncyValue { get => bouncyValue; private set => bouncyValue = value; }
    public ColorEnum ColorEnum { get => colorEnum; private set => colorEnum = value; }
}
