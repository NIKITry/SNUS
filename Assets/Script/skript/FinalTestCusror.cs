using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTestCusror : MonoBehaviour
{
    public GameObject canvas;
    private void Start()
    {
        canvas.SetActive(false);
    }

    private void Update()
    {
       /* if(healthBatal1_Radio.proideno == 6)
        {
            canvas.SetActive(false);
        }*/
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        canvas.SetActive(true);
    }

    void OnTriggerExit(Collider myTrigger)
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        canvas.SetActive(false);
    }
}
