using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceGunCanister : MonoBehaviour
{
    public GameObject fixedGunCanister;
    public bool gunCanisterInPlace = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GunCanisterPart"))
        {
            FindObjectOfType<AudioManager>().Play("ConnectingParts");
            Destroy(other.gameObject);
            if (fixedGunCanister != null)
            {
                fixedGunCanister.SetActive(true);
                gunCanisterInPlace = true;
            }
        }
    }
}
