using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderBehavior : MonoBehaviour
{
    public Transform targetPosition;
    public float moveSpeed = 1f;
    public float maxRotation = 0f;
    public float rotationSpeed = 30f;

    private bool isMoving = false;
    private bool isRotating = false;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private void Start()
    {
        // Initial position and rotation of the ladder
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    private void Update()
    {
        if (isMoving)
        {
            // Move the ladder towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
            if (transform.position == targetPosition.position)
            {
                isRotating = true;
            }
        }

        if (isRotating)
        {
            // Calculate the desired Z-axis rotation
            float targetRotation = Mathf.Clamp(Mathf.Lerp(-80f, 0f, (transform.position - initialPosition).magnitude / (targetPosition.position - initialPosition).magnitude), -80f, 0f);

            // Smoothly rotate the ladder to the desired rotation
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 180f, targetRotation), rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Harpoon") && !isMoving)
        {
            Destroy(other.gameObject);
            isMoving = true;
        }
    }
}
