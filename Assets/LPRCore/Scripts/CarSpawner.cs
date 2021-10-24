using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private CarBehaviour carPrefab;
    [SerializeField] private WheelBehavoiur wheelPrefab;
    [SerializeField] private EngineDataSO engineSO;
    [SerializeField] private FollowAndLookAt cameraScript;

    private void Start()
    {
        CarBehaviour newCar = Instantiate(carPrefab);
        newCar.transform.position = transform.position;
        newCar.LoadData(wheelPrefab, newCar.transform, engineSO);
        InputContext.Instance.LoadData(newCar);
        cameraScript.enabled = true;
        cameraScript.LoadData(newCar.LookAtTarget, newCar.CameraPos);
    }
}
