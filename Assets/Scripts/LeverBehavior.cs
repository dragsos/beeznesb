using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehavior : MonoBehaviour
{
    public HingeJoint leverHinge;
    public float onAngle = 90f;
    public bool isOn = false;

    private void Update()
    {
        float currentAngle = leverHinge.angle;

        if (currentAngle >= onAngle && !isOn)
        {
            isOn = true;
            Debug.Log("Lever is ON");
        }
    }
}
