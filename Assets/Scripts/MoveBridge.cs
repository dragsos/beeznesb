using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBridge : MonoBehaviour
{
    public float distanceToMove = 2f;
    public float speed = 3f;
    public Vector3 finalPosition;
    public LeverBehavior lever;

    public bool bridgeCleared = false;

    void Start()
    {
        finalPosition = transform.position + Vector3.up * distanceToMove;
    }

    void Update()
    {
        if (lever.isOn)
        {
            transform.position = Vector3.MoveTowards(transform.position, finalPosition, speed * Time.deltaTime);
            if (transform.position == finalPosition)
            {
                bridgeCleared = true;
            }
        }
    }
}
