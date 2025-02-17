using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXController : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip enemyDeathSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayEnemyDeath()
    {
        audioSource.PlayOneShot(enemyDeathSound);
    }
}
