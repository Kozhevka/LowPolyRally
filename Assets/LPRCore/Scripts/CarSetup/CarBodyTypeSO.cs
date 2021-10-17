using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CarBodyType", menuName = "ScriptableObjects/CarBodySO", order = 1)]
public class CarBodyTypeSO : MonoBehaviour
{
    [SerializeField] private Transform frontLeftWheelPos;
    [SerializeField] private Transform frontRightWheelPos;
    [SerializeField] private Transform backLeftWheelPos;
    [SerializeField] private Transform backRightWheelPos;
}
