using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceGunBarrel : MonoBehaviour
{
    public GameObject fixedGunBarrel;
    public bool gunBarrelInPlace = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GunBarrelPart"))
        {
            Destroy(other.gameObject);
            if (fixedGunBarrel != null)
            {
                fixedGunBarrel.SetActive(true);
                gunBarrelInPlace = true;
            }
        }
    }
}
