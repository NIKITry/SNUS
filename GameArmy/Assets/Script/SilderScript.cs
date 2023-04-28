
using UnityEngine;
using UnityEngine.UI;

public class SilderScript : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource voiceAudio;
    public AudioSource voiceAudio2;
    public AudioSource voiceAudio3;
    public AudioSource voiceAudio4;

    void Start()
    {
        volumeSlider.onValueChanged.AddListener(delegate { AdjustVoiceVolume(); });
    }

    void AdjustVoiceVolume()
    {
        voiceAudio.volume = volumeSlider.value;
        voiceAudio2.volume = volumeSlider.value;
        voiceAudio3.volume = volumeSlider.value;
        voiceAudio4.volume = volumeSlider.value;
    }
}
