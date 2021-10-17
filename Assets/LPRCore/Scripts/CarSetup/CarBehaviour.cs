using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class CarBehaviour : MonoBehaviour
{
    [SerializeField] private Transform[] wheelsPosition = new Transform[4];

    [SerializeField] private WheelValuesInCarBoby[] frontWheels = new WheelValuesInCarBoby[2];
    [SerializeField] private WheelValuesInCarBoby[] backWheesl = new WheelValuesInCarBoby[2];

    
}
