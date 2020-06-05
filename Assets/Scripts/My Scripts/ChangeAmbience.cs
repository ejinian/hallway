using UnityEngine;
using System.Collections;

public class ChangeAmbience : MonoBehaviour {
    
    public AudioSource colliderMusic;

    void Start ()
    {

    }

    public void ChangeMusic(AudioClip music)
    {
        colliderMusic.Stop();
        colliderMusic.clip = music;
        colliderMusic.Play();
    }
}
