using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPathing : MonoBehaviour
{
    // Reference to the waypoints system
    [SerializeField] private Waypoints waypoints;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotateSpeed = 2f;
    [SerializeField] private float distanceThreshold = 0.1f;

    // Current waypoint the robot is moving towards
    private Transform currentWaypoint;

    // The rotation target for the current frame
    private Quaternion rotationGoal;
    // The direction to the next waypoint that the robot needs to rotate towards
    private Vector3 directionToWaypoint;

    void Start()
    {
        // Set initial position to the first waypoint
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        // Set the next waypoint target
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.LookAt(currentWaypoint);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            //transform.LookAt(currentWaypoint);
        }
        RotateTowardsWaypoint();
    }

    // Will slowly rotate robot towards the current waypoint it is moving towards
    private void RotateTowardsWaypoint()
    {
        directionToWaypoint = (currentWaypoint.position - transform.position).normalized;
        rotationGoal = Quaternion.LookRotation(directionToWaypoint);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationGoal, rotateSpeed * Time.deltaTime);
    }
}
