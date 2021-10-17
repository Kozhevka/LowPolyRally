using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    [SerializeField] private WheelCollider[] turnWheels;

    public AnimationCurve rotateCurve;

    [SerializeField] private float radius;
    
    public float inputRotation;

    private void FixedUpdate()
    {
        if (inputRotation > 0)
        {
            turnWheels[0].steerAngle = Mathf.Rad2Deg * Mathf.Atan(2.55f / (radius + (1.5f / 2))) * inputRotation;
            turnWheels[1].steerAngle = Mathf.Rad2Deg * Mathf.Atan(2.55f / (radius - (1.5f / 2))) * inputRotation;
        }
        else if (inputRotation < 0)
        {
            turnWheels[0].steerAngle = Mathf.Rad2Deg * Mathf.Atan(2.55f / (radius + (1.5f / 2))) * inputRotation;
            turnWheels[1].steerAngle = Mathf.Rad2Deg * Mathf.Atan(2.55f / (radius - (1.5f / 2))) * inputRotation;
        }
        else
        {
            turnWheels[0].steerAngle = 0;
            turnWheels[1].steerAngle = 0;
        }
    }
}
