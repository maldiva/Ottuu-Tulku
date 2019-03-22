using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioStart : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    void Start()
    {
        audioSource.clip = audioClip;
    }

    void Update()
    {
        if (Input.GetButton("StartButton"))
        {
            audioSource.Play();
        }
    }


}
