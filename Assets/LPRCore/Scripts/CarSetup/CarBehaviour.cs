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

    [SerializeField] private TurnManager turnManager;
    [SerializeField] private BrakeSystem brakeSystem;

    [SerializeField] private Transform enginePosition;

    [SerializeField] private EngineBehavior currentEngine;

    [Header("Differential")]
    [SerializeField] private DifferentialStruct[] differentials = new DifferentialStruct[1];
    private int wheelCount;

    public EngineBehavior CurrentEngine { get => currentEngine; set => currentEngine = value; }

    private void Awake()
    {
        wheelCount = differentials.Length * 2;
    }


    public void LoadData(WheelBehavoiur wheelBehavoiur, Transform parent, EngineDataSO engineSO)
    {
        currentEngine = (EngineBehavior)Instantiate(engineSO.EnginePrefab, enginePosition);

        currentEngine.SetCar(this);

        foreach (var wheel in frontWheels)
        {
            WheelBehavoiur wheelTransform = Instantiate(wheelBehavoiur, wheel.TargetPosition);

            //wheelTransform.transform.SetParent(parent);
            //wheelTransform.transform.localRotation = Quaternion.Euler(Vector3.zero);
        }

        List<WheelBehavoiur> accelerationWheels = new List<WheelBehavoiur>();

        for (int i = 0; i < backWheels.Length; i++)
        {
            WheelBehavoiur wheelBeh = Instantiate(wheelBehavoiur, backWheels[i].TargetPosition);
            accelerationWheels.Add(wheelBeh);
        }

        for (int i = 0, y = 0; i < differentials.Length; i++)
        {
            differentials[i].LeftWheel = accelerationWheels[y];
            y++;
            differentials[i].RightWheel = accelerationWheels[y];
            y++;
        }
        //foreach (var wheel in backWheels)
        //{
        //    
        //    //wheelTransform.transform.SetParent(parent);
        //    //wheelTransform.transform.localRotation = Quaternion.Euler(Vector3.zero);
        //}
    }

    public void AddWheelAcceleration(float rotationForce)
    {
        foreach (var differential in differentials)
        {
            differential.LeftWheel.CurrentWheel.motorTorque = rotationForce;
            differential.RightWheel.CurrentWheel.motorTorque = rotationForce;
        }
    }

    public float CountAverageSlip()
    {
        float slipSumm = 0f;

        foreach (var differential in differentials)
            slipSumm += differential.LeftWheel.SlipValue + differential.RightWheel.SlipValue;

        return slipSumm / wheelCount;
    }

}
