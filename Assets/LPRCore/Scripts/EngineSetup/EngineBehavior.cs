using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (AudioSource))]
public class EngineBehavior : MonoBehaviour
{
    [SerializeField] private AudioSource thisAudiosource;
    [SerializeField] private EngineDataSO engineDataSO;
    [SerializeField] private AnimationCurve gearsAnimationCurve;
    [SerializeField] private float coolingSpeed = 10f;
    private CarBehaviour thisCar;

    private float accelarationValue;
    private float audioPintchMultiplier;
    private float minimumPintch = 1f;
    private float maximumPintch = 2.5f;

    [Header("RPM"), SerializeField] private float engineRPM;
    [SerializeField] private float averageSlip;


    public AudioSource ThisAudiosource { get => thisAudiosource; }


    public void IncomeAcceleration(float value) => accelarationValue = value;

    private void Reset()
    {
        if (TryGetComponent<AudioSource>(out AudioSource audioSource) && thisAudiosource == null)
        {
            thisAudiosource = audioSource;
        }

        if (thisAudiosource != null)
        {
            thisAudiosource.clip = engineDataSO.EngineSound;
        }
    }

    private void Awake()
    {
        if (thisAudiosource.clip == null)
            thisAudiosource.clip = engineDataSO.EngineSound;

        CalculateAudioPintchMultiplier();
    }

    private void Start()
    {
        thisAudiosource.Play();
        Debug.Log("Play");
    }

    public void SetCar(CarBehaviour thisCar)
    {
        this.thisCar = thisCar;
    }


    private void FixedUpdate()
    {
        
        //averageSlip = 1 - thisCar.CountAverageSlip();
        
        if (engineRPM < 0)
        {
            engineRPM = 0;
        }

        if (accelarationValue > 0)
        {
            
            engineRPM = accelarationValue * engineDataSO.TorqueCurve.Evaluate(accelarationValue);
            thisCar.AddWheelAcceleration(engineRPM*0.75f);
            SetAudioPintch();
            return;
        }

        if (engineRPM > 0)
        engineRPM -= coolingSpeed * Time.deltaTime;
        SetAudioPintch();
        thisCar.AddWheelAcceleration(0f);
    }


    private void CalculateAudioPintchMultiplier()
    {
        int minMaxCount = engineDataSO.MaxEngineRPM - engineDataSO.MinimumRPM;
        float pintchCount = maximumPintch - minimumPintch;

        audioPintchMultiplier = pintchCount / minMaxCount;
    }

    private void SetAudioPintch()
    {
        thisAudiosource.pitch = minimumPintch + ((engineRPM - engineDataSO.MinimumRPM) * audioPintchMultiplier);
    }

}
