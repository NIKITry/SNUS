using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class VideoTrigger : MonoBehaviour
{


    public GameObject _newvideo;
     VideoPlayer _videoPlayer;
     int i = 0;
    void Start()
    {

        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.Prepare();

        _videoPlayer.loopPointReached += _videoPlayer_loopPointReached;

        Invoke("play", 1);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void _videoPlayer_loopPointReached(VideoPlayer source)
    {
        Cursor.lockState = CursorLockMode.Locked;
        Room_KID.enter = false;
        _newvideo.SetActive(true);
        gameObject.SetActive(false);
       
       
    }

    private void play()
    {
        _videoPlayer.Play();
    }

   
}



