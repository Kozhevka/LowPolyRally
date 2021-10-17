using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TorqueInput : MonoBehaviour, IPointerUpHandler
{
    [SerializeField] private Scrollbar torqueScrollbar;
    [SerializeField] private InputContext inputContextScript;

    void Start()
    {
        torqueScrollbar.onValueChanged.AddListener((float val) => ScrollbarCallback(val));
        
    }

    void ScrollbarCallback(float value)
    {
        inputContextScript.MethodRespondingToTorque(value);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        torqueScrollbar.value = 0;
    }
}
