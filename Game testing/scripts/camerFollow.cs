using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerFollow : MonoBehaviour
{
    [SerializeField] private Transform target; // The transform of the object that the camera should follow
    [SerializeField] private Vector3 offset; // The offset from the target that the camera should maintain
    [SerializeField] private float smoothTime = 0.3f; // The time it takes for the camera to smoothly follow the target
    private Vector3 velocity = Vector3.zero; // The current velocity of the camera

    private void LateUpdate()
    {
        Vector3 targetPosition = target.TransformPoint(offset); // Calculate the target position for the camera to move to
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime); // Smoothly move the camera towards the target position
        //transform.LookAt(target); // Make the camera look at the target
    }
}
