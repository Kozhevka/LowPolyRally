using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private CarBehaviour carPrefab;
    [SerializeField] private WheelBehavoiur wheelPrefab;

    private void Start()
    {
        CarBehaviour newCar = Instantiate(carPrefab);
        newCar.transform.position = transform.position;
        newCar.LoadWheels(wheelPrefab, newCar.transform);
    }
}
