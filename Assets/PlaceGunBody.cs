using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceGunBody : MonoBehaviour
{
    public GameObject fixedGunBody;
    public bool gunBodyInPlace = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GunBodyPart"))
        {
            FindObjectOfType<AudioManager>().Play("ConnectingParts");
            Destroy(other.gameObject);
            if (fixedGunBody != null)
            {
                fixedGunBody.SetActive(true);
                gunBodyInPlace = true;
            }
        }
    }
}
