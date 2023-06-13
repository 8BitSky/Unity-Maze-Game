using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMover : MonoBehaviour
{
    public float speed = 1.0f;          // Speed of the tilt motion
    public float tiltAngle = 15.0f;     // Angle of the tilt motion

    private float tiltDirection = 1.0f; // Direction of the tilt motion (+1 or -1)
    private float initialRotation;      // Initial rotation of the floor

    private void Start()
    {
        // Store the initial rotation of the floor
        initialRotation = transform.rotation.eulerAngles.x;
    }

    private void Update()
    {
        // Calculate the new rotation angle using a sine wave function
        float newRotation = initialRotation + (Mathf.Sin(Time.time * speed) * tiltAngle * tiltDirection);

        // Apply the new rotation to the floor
        transform.rotation = Quaternion.Euler(newRotation, 0.0f, 0.0f);

        // Reverse the direction of the tilt motion if the floor has reached its maximum tilt angle
        if (Mathf.Abs(newRotation - initialRotation) >= tiltAngle)
        {
            tiltDirection = -tiltDirection;
        }
    }
}
