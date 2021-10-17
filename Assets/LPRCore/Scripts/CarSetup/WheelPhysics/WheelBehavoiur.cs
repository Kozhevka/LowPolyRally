using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelBehavoiur : MonoBehaviour
{
    [SerializeField] private Transform wheelBody;

    [SerializeField] private WheelCollider currentWheel;
    private Color currentColor;
    private ColorEnum currentColorEnum = 0;
    private MeshRenderer currentMapRender;

    private const int forwardFriction = 0;
    private const int sideFriction = 1;

    public WheelCollider CurrentWheel { get => currentWheel; private set => currentWheel = value; }

    private void Start()
    {
        currentColorEnum = 0;
        currentMapRender = ColorDetector.Instance.CurrentMap;
    }

    private void FixedUpdate()
    {
        UpdateGroundType();
        UpdateWheelPos();
    }


    private void UpdateWheelPos()
    {
        Vector3 pos = wheelBody.position;
        Quaternion rot = wheelBody.rotation;

        CurrentWheel.GetWorldPose(out pos, out rot);
        wheelBody.position = pos;
        wheelBody.rotation = rot;
    }

    private void UpdateGroundType()
    {
        if (CurrentWheel.GetGroundHit(out WheelHit wheelHit))
        { 
       //tmpText.text = wheelHit.forwardSlip.ToString();
            Color groundColor = DetectColor();
            
            WheelGroundColor wheelGroundColor = ColorDetector.Instance.DetectColorType(groundColor, currentColorEnum);

            if (wheelGroundColor == null) 
            return;

         //   if (colorImage != null)
        //    colorImage.color = groundColor;

            currentColorEnum = wheelGroundColor.ColorEnumType;
            ColorStruct colorStruct = wheelGroundColor.ColorStruct;


            CurrentWheel.forwardFriction = UpdateFrictionCurve(colorStruct.ForwardFrictionCurve);
            CurrentWheel.sidewaysFriction = UpdateFrictionCurve(colorStruct.SideFrictionCurve);

            CurrentWheel.wheelDampingRate = colorStruct.BouncyValue;


        }
    }

    private WheelFrictionCurve UpdateFrictionCurve(CustomWheelFrictionCurve customCurve)
    {
        WheelFrictionCurve newWheelFrictionCurve = new WheelFrictionCurve() {
            asymptoteSlip = customCurve.AsymptoteSlip,
            asymptoteValue = customCurve.AsymptoteValue,
            extremumSlip = customCurve.ExtremumSlip,
            extremumValue = customCurve.ExtremumValue,
            stiffness = customCurve.Stiffness };
        return newWheelFrictionCurve;
    }

    private Color DetectColor()
    {
        RaycastHit hit;
        Physics.Raycast(CurrentWheel.transform.position, Vector3.down, out hit);

        MeshCollider meshCollider = hit.collider as MeshCollider;

        ///if (rend == null)
        ///    Debug.Log("rend == null");
        ///if (rend.sharedMaterial == null)
        ///    Debug.Log("rend.sharedMaterial == null");
        ///if (rend.sharedMaterial.mainTexture == null)
        ///    Debug.Log("rend.sharedMaterial.mainTexture == null");
        ///if (meshCollider == null)
        ///    Debug.Log("(meshCollider == null");

        Texture2D tex = currentMapRender.material.mainTexture as Texture2D;
        Vector2 pixelUV = hit.textureCoord;
        pixelUV.x *= tex.width;
        pixelUV.y *= tex.height;

        return tex.GetPixel((int)pixelUV.x, (int)pixelUV.y);
    }
}
