using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI fpsTMP;
    void Update()
    {
        fpsTMP.text = "Fps: " + (int)(1f / Time.unscaledDeltaTime);
    }
}
