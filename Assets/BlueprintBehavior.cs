using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueprintBehavior : MonoBehaviour
{
    public GameManager gameManagerScript;

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
            FindObjectOfType<AudioManager>().Play("Voice_Line28");
            gameManagerScript.gunCleared = true;
            Destroy(gunBody);
            Destroy(gunBarrel);
            Destroy(gunCanister);
            assembledGun.SetActive(true);
            blueprintMeshRenderer.enabled = false;
        }
    }
}
