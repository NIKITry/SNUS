using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource Fx;
    public AudioClip hoverClip;
    public AudioClip ClicClip;
    // Start is called before the first frame update
   

    // Update is called once per frame
    public void HoverAudioClip()
    {
        Fx.PlayOneShot(hoverClip);
    }
    public void ClicAudioClip()
    {
        Fx.PlayOneShot(ClicClip);
    }
}
