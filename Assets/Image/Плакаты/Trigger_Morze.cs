using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger_Morze : MonoBehaviour
{

    public GameObject Fps_1;
    public GameObject Fps_2;
    public GameObject LordCanvas;
    public GameObject Camera_Morze;
   
    public GameObject Morze_on;
    bool enter;
    private void Start()
    {
        Morze_on.SetActive(false);
        enter = false;
    }
    private void Update()
    {
        if(enter == true)
        {
           
            Morze_on.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                Fps_1.SetActive(false);
                Fps_2.SetActive(false);

                LordCanvas.SetActive(false);
                Camera_Morze.SetActive(true);
            }
        }

        else
        {
            
            Morze_on.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enter = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
        }

    }
}
