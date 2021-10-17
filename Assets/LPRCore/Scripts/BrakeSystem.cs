using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeSystem : MonoBehaviour
{
    //private float brakingForce;

    [SerializeField] private WheelCollider[] wheelColiders;

    [Range(0,1)]
    [SerializeField] private float backFrontBalance;
    [SerializeField] private float brakeForce;




    public void Braking(float brakeInput)
    {
        
        wheelColiders[0].brakeTorque = brakeInput * (backFrontBalance) * brakeForce;
        wheelColiders[1].brakeTorque = brakeInput * (backFrontBalance) * brakeForce;

        wheelColiders[2].brakeTorque = brakeInput * (1 - backFrontBalance) * brakeForce;
        wheelColiders[3].brakeTorque = brakeInput * (1 - backFrontBalance) * brakeForce;
    }
}
