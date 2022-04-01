using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class collectAudio : MonoBehaviour
{
    public AudioSource collectable;
    public AudioSource complete;

    // Update is called once per frame
    public void playCollectAudio()
    {
        collectable.Play();
    }
    public void playComplete()
    {
        complete.Play();
    }
}
