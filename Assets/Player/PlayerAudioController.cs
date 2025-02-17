using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip getItemSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayGetItem()
    {
        audioSource.PlayOneShot(getItemSound);
    }
}
