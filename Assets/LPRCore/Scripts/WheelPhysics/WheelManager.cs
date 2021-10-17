using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WheelManager : MonoBehaviour
{
    public Transform[] bodyWheels;


    public WheelCollider[] wheelColliders;
    [SerializeField] private Image[] colorGroundHit;
    [SerializeField] private TextMeshProUGUI[] slipValues;
    int layerMask = 1 << 8;
    private void FixedUpdate()
    {
        for (int i = 0; i < bodyWheels.Length; i++)
        {
            UpdateWheelPos(wheelColliders[i], bodyWheels[i]);
        }
    }

    private void UpdateWheelPos(WheelCollider col, Transform bodyTransforn)
    {
        Vector3 pos = bodyTransforn.position;
        Quaternion rot = bodyTransforn.rotation;

        col.GetWorldPose(out pos, out rot);
        bodyTransforn.position = pos;
        bodyTransforn.rotation = rot;
    }

    
}
