using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] private bool canLoop = true;

    private void OnDrawGizmos()
    { 
        // Drawing waypoints
        foreach (Transform t in transform)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(t.position, .15f);
        }

        // Drawing lines between waypoints
        Gizmos.color = Color.red;
        for (int i = 0; i < transform.childCount - 1; i++)
        {
            Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);
        }

        // If the path is set to loop then draw a line between the last and first waypoint
        if (canLoop)
        {
            Gizmos.DrawLine(transform.GetChild(transform.childCount - 1).position, transform.GetChild(0).position);
        }

    }

    // Finding the next waypoint based on the hierarchy
    public Transform GetNextWaypoint(Transform currentWaypoint)
    {
        if (currentWaypoint == null)
        {
            return transform.GetChild(0);
        }

        if (currentWaypoint.GetSiblingIndex() < transform.childCount - 1)
        {
            return transform.GetChild(currentWaypoint.GetSiblingIndex() + 1);
        }
        else
        {
            if (canLoop)
            {
                return transform.GetChild(0);
            }
            else
            {
                return transform.GetChild(currentWaypoint.GetSiblingIndex());
            }    
        }
    }
}
