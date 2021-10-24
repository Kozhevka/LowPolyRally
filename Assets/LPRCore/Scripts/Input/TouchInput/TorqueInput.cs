using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class TorqueInput : MonoBehaviour, IPointerUpHandler
{
    [SerializeField] private Scrollbar torqueScrollbar;
    [SerializeField] private InputContext inputContextScript;
    private bool pressing;


    void Start()
    {
        torqueScrollbar.onValueChanged.AddListener((float val) => ScrollbarCallback(val));
        
    }

    void ScrollbarCallback(float value)
    {
        if (pressing == false)
            pressing = true;

        inputContextScript.MethodRespondingToTorque(value);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        torqueScrollbar.value = 0;
        inputContextScript.MethodRespondingToTorque(0);
    }

}
