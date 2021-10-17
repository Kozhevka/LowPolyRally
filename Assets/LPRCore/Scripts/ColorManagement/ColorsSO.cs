using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorSO", menuName = "ScriptableObjects/ColorHolderSO", order = 1)]
public class ColorsSO : ScriptableObject
{
    [SerializeField] private ColorStruct[] colorStructArray;
    [SerializeField] private CustomWheelFrictionCurve defaultFrictionCurve;

    public ColorStruct[] ColorStructArray { get => colorStructArray; private set => colorStructArray = value; }

    //public void SetDefaultColorFrictionCurve()
    //{
    //    Debug.Log("Start SO setup");
    //    for (int i = 0; i < colorStructArray.Length; i++)
    //    {
    //        colorStructArray[i].ForwardFrictionCurve = defaultFrictionCurve;
    //        colorStructArray[i].SideFrictionCurve = defaultFrictionCurve;
    //    }
    //}


    //public ColorEnum GetColorEnum(Color inputColor)
    //{
    //    string target = "nes" + ColorUtility.ToHtmlStringRGB(inputColor);
    //    ColorEnum colorEnum;
    //    return colorEnum;
    //}
    //public void AddColorToArray(Color newColor)
    //{
    //    ColorStruct[] bootStructArray = new ColorStruct[colorStructArray.Length + 1];
    //
    //    for (int i = 0; i < colorStructArray.Length; i++)
    //        bootStructArray[i] = colorStructArray[i];
    //
    //    ColorStruct newColorStruct = new ColorStruct();
    //
    //    newColorStruct.ColorCode = ColorUtility.ToHtmlStringRGB(newColor);
    //    newColorStruct.ColorRGB = new Vector3(newColor.r, newColor.g, newColor.b);
    //    newColorStruct.Color = newColor;
    //
    //    newColorStruct.MaterialName = newColorStruct.ColorCode;
    //    newColorStruct.ForwardSlipValue = defaultSlipValue;
    //    newColorStruct.SideSlipValue = defaultSlipValue;
    //    newColorStruct.BouncyValue = defaultBouncyValue;
    //    newColorStruct.ColorEnum = (ColorEnum)(bootStructArray.Length - 1);
    //    bootStructArray[bootStructArray.Length - 1] = newColorStruct;
    //    colorStructArray = bootStructArray;
    //    Debug.Log($"Complete. color {newColorStruct.ColorCode}, added by {colorStructArray.Length-1} index");
    //}
}
