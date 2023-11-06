using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakLock : MonoBehaviour
{
    public bool crateOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crowbar"))
        {
            crateOpen = true;
            Debug.Log("Crate is open");
        }
    }
}