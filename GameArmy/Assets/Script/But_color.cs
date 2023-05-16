using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class But_color : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioClip din;
    AudioSource AudioCameraFly;

    private Text but;
    private Color old;
    public Color neww;

    void Start()
    {
        AudioCameraFly = GameObject.FindGameObjectWithTag("CameraFly").gameObject.GetComponent<AudioSource>();
        Debug.Log(AudioCameraFly);
        but = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
        old = but.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (gameObject.transform.tag == "TestButton")
        {
            but.color = neww;
            AudioCameraFly.PlayOneShot(din);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (gameObject.transform.tag == "TestButton")
            but.color = old;
    }
}

