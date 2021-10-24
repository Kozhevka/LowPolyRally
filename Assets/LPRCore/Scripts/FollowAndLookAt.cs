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

    

    private void FixedUpdate()
    {
        if(moveTarget != null)
        {
            Vector3 smoothedTargetPosition = Vector3.Lerp(lookAtTarget.position, previousFramePos, moveSmooth);

            transform.LookAt(smoothedTargetPosition, Vector3.up);

            transform.position = Vector3.Lerp(transform.position, moveTarget.position + UpPosition, moveSmooth);

            previousFramePos = lookAtTarget.position;
        }
    }

    public void LoadData(Transform lookTarget, Transform targetPos)
    {
        lookAtTarget = lookTarget;
        moveTarget = targetPos;
    }
}
