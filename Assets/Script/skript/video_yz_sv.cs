using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video_yz_sv : MonoBehaviour
{
    public GameObject razvilka_trigger;
    public GameObject razvilka_cam;
    public GameObject video_divis;
    public GameObject Video;
    
    public void Prodolshit()
    {
        razvilka_cam.GetComponent<AudioSource>().enabled = false;
        razvilka_cam.GetComponent<VideoPlayer>().enabled = false;
        razvilka_cam.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        video_divis.SetActive(true);
        Video.SetActive(false);
        razvilka_cam.SetActive(false);

        // Destroy(Ozvuchka);
        // k = 1;

    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        razvilka_cam.SetActive(true);
        StartCoroutine(video_stop());
    }
    IEnumerator video_stop()
    {

        //flag = true;
        //razvilka_cam.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        yield return new WaitForSeconds(132.0f);
        video_divis.SetActive(true);
        Video.SetActive(false);
        razvilka_cam.SetActive(false);
        razvilka_cam.GetComponent<VideoPlayer>().enabled = false;
        razvilka_cam.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        razvilka_trigger.SetActive(false);

    
    }
}
