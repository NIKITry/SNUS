using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_video_yz_cv : MonoBehaviour
{
    public GameObject First_video;
    public GameObject Second_video;
    public GameObject FPS;
    public GameObject Kamen;
    public Kamen_division KamDis;
    public GameObject start_video_cam;
    public GameObject start_video_canv;
    public GameObject LordCanvas;
    bool flag = true;
    public void OnClick()
    {
        First_video.SetActive(false);
        Second_video.SetActive(true);
        start_video_cam.SetActive(false);
        start_video_canv.SetActive(false);
       
       
       // FPS.SetActive(true);
       // Kamen.GetComponent<SphereCollider>().enabled = false;
       // Cursor.visible = false;
      //  Cursor.lockState = CursorLockMode.Locked;
        flag = false;
      //  KamDis.FPSNIK.GetComponent<FPSCONROL>().enabled = true;
      //  KamDis.FPSNIK.GetComponent<тело>().enabled = true;
      //  KamDis.FPSNIK_camera.GetComponent<тело>().enabled = true;
      //  LordCanvas.SetActive(true);
    }
    public void OneClick()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            start_video_cam.SetActive(true);
            start_video_canv.SetActive(true);
            FPS.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            StartCoroutine(video_stop());
        }

        if (flag == true && F.flag_weapon == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            StartCoroutine(video_stop());
        }
    }

    IEnumerator video_stop()
    {
        yield return new WaitForSeconds(120.0f);
        First_video.SetActive(false);
        Second_video.SetActive(true);
        flag = false;
        start_video_cam.SetActive(false);
        start_video_canv.SetActive(false);
        //FPS.SetActive(true);
      //  Kamen.GetComponent<SphereCollider>().enabled = false;
      //  KamDis.FPSNIK.GetComponent<FPSCONROL>().enabled = true;
      //  KamDis.FPSNIK.GetComponent<тело>().enabled = true;
      //  KamDis.FPSNIK_camera.GetComponent<тело>().enabled = true;
       // Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
       // LordCanvas.SetActive(true);
    }
}
