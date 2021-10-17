using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class CarBehaviour : MonoBehaviour
{
    [Header("Wheels")]
    [SerializeField] private WheelValuesInCarBoby[] frontWheels = new WheelValuesInCarBoby[2];
    [SerializeField] private WheelValuesInCarBoby[] backWheels = new WheelValuesInCarBoby[2];

    [Header("Lights")]
    [SerializeField] private GameObject[] frontLights;
    [SerializeField] private GameObject[] backLights;


    public void LoadWheels(WheelBehavoiur wheelBehavoiur, Transform parent)
    {
        foreach (var wheel in frontWheels)
        {
            WheelBehavoiur wheelTransform = Instantiate(wheelBehavoiur, wheel.TargetPosition);
            //wheelTransform.transform.SetParent(parent);
            //wheelTransform.transform.localRotation = Quaternion.Euler(Vector3.zero);
        }

        foreach (var wheel in backWheels)
        {
            WheelBehavoiur wheelTransform = Instantiate(wheelBehavoiur, wheel.TargetPosition);
            //wheelTransform.transform.SetParent(parent);
            //wheelTransform.transform.localRotation = Quaternion.Euler(Vector3.zero);
        }
    }
    
}
