using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CrateGunPieces : MonoBehaviour
{
    public BreakLock breakLockScript;
    public XRGrabInteractable interactable;
    private Rigidbody rb;

    private bool inPlace = false;
    private bool hasBeenPickedUp = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (breakLockScript != null && breakLockScript.crateOpen)
        {
            inPlace = true;
        }

        if (interactable.isSelected)
        {
            if (!hasBeenPickedUp)
            {
                hasBeenPickedUp = true;
                inPlace = false;
                rb.isKinematic = false;
            }
        }
    }
}
