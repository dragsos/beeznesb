using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioManager AudioManager;

    void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<AudioManager>();
    }
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("Underwater Ambiance");
        AudioManager.Play("Underwater Ambiance");
    }

}
