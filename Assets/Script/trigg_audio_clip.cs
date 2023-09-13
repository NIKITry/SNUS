using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigg_audio_clip : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            obj.gameObject.SetActive(false);
    }
}
