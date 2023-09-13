using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMusic : MonoBehaviour
{
    

    public AudioClip[] clips;
    public AudioSource audioSourse;

private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }
    void Update()

    {
        if (!audioSourse.isPlaying)
        {
            audioSourse.clip = GetRandomClip();
            audioSourse.Play(); 
        }
    }
    
}
