using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLid : MonoBehaviour
{
    public BreakLock breakLockScript;
    public Transform targetRotation;
    public GameObject gunPiece;
    public GameObject blueprint;

    public bool openBlueprint = false;

    public float rotationSpeed = 220f;

    void Update()
    {
         if (breakLockScript != null && breakLockScript.crateOpen)
         {
            Quaternion targetQuaternion = targetRotation.rotation;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetQuaternion, rotationSpeed * Time.deltaTime);
            if (gunPiece != null)
            {
                gunPiece.SetActive(true);
            }
        }
    }
}
