using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverFix : MonoBehaviour
{
    public GameObject lever;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lever"))
        {
            FindObjectOfType<AudioManager>().Play("ConnectingParts");
            Destroy(other.gameObject);
            if (lever != null)
            {
                lever.SetActive(true);
            }
        }
    }
}
