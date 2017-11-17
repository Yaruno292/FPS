using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Ammo : MonoBehaviour {

    public static float bulletsRemaining = 24;
    public static bool reload = false;
    int timer = 0;

    public static int i = 0;

    public AudioClip shootClip;
    private AudioMixerGroup output;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0) && reload == false)
        {

            i += 1;

            if (i >= 5)
            {

                bulletsRemaining -= 1;
                i = 0;
                AudioSource sourceShoot = gameObject.AddComponent<AudioSource>();
                // Load clip into the AudioSource
                sourceShoot.clip = shootClip;

                // Set the output for AudioSource
                sourceShoot.outputAudioMixerGroup = output;

                // Play the clip
                sourceShoot.Play();

                Destroy(sourceShoot, shootClip.length);
            }

            if (bulletsRemaining <= 0)
            {
                reload = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            reload = true;
        }

        if (reload == true)
        {
            timer += 1;
        }
        if(timer >= 50)
        {
            bulletsRemaining = 24;
            timer = 0;
            reload = false;
            
        }
    }
}
