using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggTestBegin : MonoBehaviour
{
    public GameObject TestBeginButton, TestGeneral, CameraFlyAround ;
    GameObject Player;
    bool enter;

    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
 
    }
    public void Update()
    {
        if (enter && Input.GetKeyDown(KeyCode.E))
        {
            CameraFlyAround.GetComponent<Camera>().enabled = true;
            TestBeginButton.SetActive(false);
            TestGeneral.SetActive(true);
            //Player.GetComponent<FPSCONROL>().enabled = false;
            Player.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            TestBeginButton.SetActive(true);
            enter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            TestBeginButton.SetActive(false);
            enter = false;
        }
    }

    public void ExitTest()
    {
        Player.SetActive(true);
        TestBeginButton.SetActive(true);
        TestGeneral.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        CameraFlyAround.GetComponent<Camera>().enabled = false;
    }
}
