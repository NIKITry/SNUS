using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVideo : MonoBehaviour
{
    public bool enter;
    public GameObject Text, Button_skip;
    public GameObject video_start;


    private void Update()
    {
        if (enter && Input.GetKeyDown(KeyCode.R))
        {
            video_start.SetActive(true);
            Text.SetActive(false);
            Button_skip.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = true;
            Text.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
            Text.SetActive(false);
        }
    }
}
