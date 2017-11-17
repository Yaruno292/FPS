using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RandomSongs : MonoBehaviour
{

    public AudioClip[] clips;
    public AudioMixerGroup output;
    AudioSource audioSource;

    public float minPitch = 0.95f;
    public float maxPitch = 1.05f;

    // Update is called once per frame
    void Start()
    {
        PlaySound();
    }

    void PlaySound()
    {
        // Randomize
        int randomClip = Random.Range(0, clips.Length);

        // Create an AudioSource
        AudioSource source = gameObject.AddComponent<AudioSource>();

        // Load clip into the AudioSource
        source.clip = clips[randomClip];

        // Set the output for AudioSource
        source.outputAudioMixerGroup = output;

        // Play the clip
        source.Play();

        // Destroy the AudioSource when done playing clip
        Destroy(source, clips[randomClip].length);
    }
}