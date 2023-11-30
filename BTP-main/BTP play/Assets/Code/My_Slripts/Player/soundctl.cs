using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundctl : MonoBehaviour
{

    public AudioClip[] sounds;
    private AudioSource audioSrc=> GetComponent<AudioSource>();
    
    public void PlaySound(AudioClip clip,float volume=0.1f, bool destroyed=false, float p1=0.05f,float p2 = 1.2f)
    {
        audioSrc.PlayOneShot(clip, volume);
    }
}
