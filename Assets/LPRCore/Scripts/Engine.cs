using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public float minRPM = 7000f;
    public float maxRPM;

    [SerializeField] private float awesomnesMultiplier;

    public float finalDriveRatio;

    [SerializeField] private float motorRPM;

    [SerializeField] private TextMeshProUGUI motorRPM_UI;
    [SerializeField] private TextMeshProUGUI currentGear_UI;
 
    public AnimationCurve torqueCurve;
    public AnimationCurve switchGearCurve;


    [Range(-1, 6)]
    [SerializeField] private int currentGear = 1;
    [SerializeField] WheelCollider[] torqueWheels;
    [SerializeField] private float[] torqueWheelsFloat;
    [SerializeField] private float differenceForActivateDiferential  = 1000f;

    float wheelRPM;
    [SerializeField] public float totalMotorTorque;

    public float accel = 0.5f;

    private void FixedUpdate()
    {
        
        motorRPM = minRPM + (wheelRPM * finalDriveRatio * switchGearCurve.Evaluate(currentGear));
        
        motorRPM_UI.text = $"motorRPM {Math.Round(motorRPM, 1)}";
        
        totalMotorTorque = torqueCurve.Evaluate(motorRPM) * switchGearCurve.Evaluate(currentGear) * finalDriveRatio * accel;
        
        foreach (var item in torqueWheels)
        {
            item.motorTorque = totalMotorTorque;
        }
        Differential();
    
        wheelRPM = (torqueWheels[0].rpm + torqueWheels[1].rpm) / 2 * awesomnesMultiplier;
    
    }

    private void Differential()
    {
        if (torqueWheels[0].rpm - differenceForActivateDiferential > torqueWheels[1].rpm)
        {
            torqueWheels[1].motorTorque += differenceForActivateDiferential;
            return;
        }
        torqueWheels[0].motorTorque += differenceForActivateDiferential;
    }

    public void InputAcceleration(float acceleration)
    {
        accel = acceleration;
    }
    public void InputGear(bool upOrDown)
    {
        if (upOrDown && currentGear < 6)
        {
            currentGear++;
            currentGear_UI.text = $"Gear: {currentGear}";
            return;
        }
        if (currentGear < 0)
            return;
        currentGear--;
        currentGear_UI.text = $"Gear: {currentGear}";
    }
}
