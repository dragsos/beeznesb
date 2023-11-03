using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotLookTargeting : MonoBehaviour
{
    // Looking at the player while stationary
    public Transform target;
    public float speed = 5f;

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
