using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugLogWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDebug;




    private void OnEnable()
    {
        Application.logMessageReceived += LogCallback;
    }

    private void OnDisable()
    {
        Application.logMessageReceived -= LogCallback;
    }

    void LogCallback(string logString, string stackTrace, LogType type)
    {
        textDebug.text += logString + "   |   ";
    }



    public void ClearLine()
    {
        textDebug.text = "Debug line cleared";

    }
}
