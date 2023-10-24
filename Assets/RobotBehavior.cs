using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBehavior : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float moveSpeed = 2;
    public Transform target;
    public float lookSpeed = 5f;
    int index = 0;

    private void Update()
    {
        // Looking at the next waypoint
        target = 
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookSpeed * Time.deltaTime);

        // Navigating between waypoints
        Vector3 destination = waypoints[index].transform.position;

        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= 0.05)
        {
            index++;
        }

        
    }
}
