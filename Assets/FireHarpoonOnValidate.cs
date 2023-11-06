using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireHarpoonOnValidate : MonoBehaviour
{
    public GameObject harpoon;
    public Transform spawnPoint;
    public float fireSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireHarpoon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireHarpoon(ActivateEventArgs arg)
    {
        GameObject spawnedHarpoon = Instantiate(harpoon);
        spawnedHarpoon.transform.position = spawnPoint.position;
        spawnedHarpoon.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedHarpoon, 20);
    }
}
