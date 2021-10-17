using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputContext : MonoBehaviour
{
    private float accelerationF;
    private float rotation;
    private float brake;

    [SerializeField] private GameObject car;
    private Engine engineScript;
    private TurnManager turnManager;
    private BrakeSystem brakeSystem;


    private void Start()
    {
        engineScript = gameObject.GetComponent<Engine>();
        turnManager = gameObject.GetComponent<TurnManager>();
        brakeSystem = gameObject.GetComponent<BrakeSystem>();
    }

    public void MethodRespondingToTorque(InputAction.CallbackContext context)
    {
        accelerationF = context.ReadValue<float>();
        //Debug.Log($"{accelerationF}");
        engineScript.InputAcceleration(accelerationF);
    }
    public void MethodRespondingToTorque(float scrollBarValue)
    {
        accelerationF = scrollBarValue;
        //Debug.Log($"{accelerationF}");
        engineScript.InputAcceleration(accelerationF);
    }

    public void MethodRespondingToRotate(InputAction.CallbackContext context)
    {
        rotation = context.ReadValue<float>();
        turnManager.inputRotation = rotation;
    }
    public void RespondToBrake(InputAction.CallbackContext context)
    {
        brake = context.ReadValue<float>();
        brakeSystem.Braking(brake);
    }
    public void RespondToBrake(float value)
    {
        brake = value;
        brakeSystem.Braking(brake);
    }

    public void RespondToUpGear(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            engineScript.InputGear(true);
        }
    }
    public void RespondToDownGear(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            engineScript.InputGear(false);
        }
    }
    public void RespondToUpGear()
    {
       engineScript.InputGear(true);
    }
    public void RespondToDownGear()
    {
        
       engineScript.InputGear(false);
        
    }
}
