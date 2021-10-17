using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAndLookAt : MonoBehaviour
{
    [SerializeField] private Transform moveTarget;
    [SerializeField] private Transform lookAtTarget;
    private Transform thisTransform;
    [SerializeField] private float moveSmooth;
    [SerializeField] private float lookSmooth;
    [SerializeField] private Vector3 UpPosition;
    Vector3 previousFramePos;

    private void Start()
    {
        thisTransform = transform;
    }

    private void FixedUpdate()
    {
        Vector3 smoothedTargetPosition = Vector3.Lerp(lookAtTarget.position, previousFramePos, Time.deltaTime * moveSmooth);

        thisTransform.LookAt(smoothedTargetPosition, Vector3.up);

        thisTransform.position = Vector3.Lerp(thisTransform.position, moveTarget.position + UpPosition, Time.deltaTime * moveSmooth);

        previousFramePos = lookAtTarget.position;
    }
}
