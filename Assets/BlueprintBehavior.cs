using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueprintBehavior : MonoBehaviour
{
    public OpenLid openLidScript;
    public PlaceGunBody placeGunBodyScript;
    public PlaceGunBarrel placeGunBarrelScript;
    public PlaceGunCanister placeGunCanisterScript;
    public GameObject gunBody;
    public GameObject gunBarrel;
    public GameObject gunCanister;
    public GameObject assembledGun;
    public MeshRenderer blueprintMeshRenderer;

    private void Update()
    {
        if (placeGunBodyScript.gunBodyInPlace && placeGunBarrelScript.gunBarrelInPlace && placeGunCanisterScript.gunCanisterInPlace)
        {
            Destroy(gunBody);
            Destroy(gunBarrel);
            Destroy(gunCanister);
            assembledGun.SetActive(true);
            blueprintMeshRenderer.enabled = false;
        }
    }
}
